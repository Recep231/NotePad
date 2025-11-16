using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotePadApp;

public partial class Form1 : Form
{
    private string? currentFilePath;
    private bool hasUnsavedChanges;
    private readonly ToolTip caretToolTip = new();
    private DateTime lastCaretTooltipShown = DateTime.MinValue;
    private bool showCaretTooltip = true;

    public Form1()
    {
        InitializeComponent();
        WordWrapMenuItem_CheckedChanged(this, EventArgs.Empty);
        this.FormClosing += Form1_FormClosing;
        caretToolTip.InitialDelay = 0;
        caretToolTip.ReshowDelay = 50;
        caretToolTip.AutoPopDelay = 900;
        caretToolTip.UseFading = true;
        caretToolTip.UseAnimation = true;
        caretToolTip.IsBalloon = true;
        richTextBox1.CaretGlowColor = Color.FromArgb(120, 0, 120, 215);
        richTextBox1.ShowCaretGlow = true;
        richTextBox1.ShowCaretGuideLines = true;
        animatedCaretToolStripMenuItem.Checked = richTextBox1.ShowCaretGlow;
        caretGuidesToolStripMenuItem.Checked = richTextBox1.ShowCaretGuideLines;
        caretTooltipToolStripMenuItem.Checked = showCaretTooltip;
        richTextBox1.Leave += (_, _) => caretToolTip.Hide(richTextBox1);
        richTextBox1.MouseLeave += (_, _) => caretToolTip.Hide(richTextBox1);
        richTextBox1.VScroll += (_, _) => richTextBox1.Invalidate();
        richTextBox1.Resize += (_, _) => richTextBox1.Invalidate();
        richTextBox1.Enter += (_, _) => ShowCaretToolTip(force: true);
        UpdateTitle();
        UpdateStatus();
    }

    private void NewFileMenuItem_Click(object? sender, EventArgs e)
    {
        if (!ConfirmDiscardChanges())
        {
            return;
        }

        richTextBox1.Clear();
        currentFilePath = null;
        hasUnsavedChanges = false;
        UpdateTitle();
        UpdateStatus();
    }

    private void OpenFileMenuItem_Click(object? sender, EventArgs e)
    {
        if (!ConfirmDiscardChanges())
        {
            return;
        }

        if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            LoadFile(openFileDialog1.FileName);
        }
        catch (Exception ex)
        {
            ShowError("Failed to open file.", ex);
        }
    }

    private void SaveFileMenuItem_Click(object? sender, EventArgs e)
    {
        if (currentFilePath == null)
        {
            SaveFileAsMenuItem_Click(sender, e);
            return;
        }

        TrySaveToPath(currentFilePath);
    }

    private void SaveFileAsMenuItem_Click(object? sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        TrySaveToPath(saveFileDialog1.FileName);
    }

    private void ExitMenuItem_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void UndoMenuItem_Click(object? sender, EventArgs e)
    {
        if (richTextBox1.CanUndo)
        {
            richTextBox1.Undo();
        }
    }

    private void RedoMenuItem_Click(object? sender, EventArgs e)
    {
        if (richTextBox1.CanRedo)
        {
            richTextBox1.Redo();
        }
    }

    private void CutMenuItem_Click(object? sender, EventArgs e)
    {
        if (richTextBox1.SelectionLength > 0)
        {
            richTextBox1.Cut();
        }
    }

    private void CopyMenuItem_Click(object? sender, EventArgs e)
    {
        if (richTextBox1.SelectionLength > 0)
        {
            richTextBox1.Copy();
        }
    }

    private void PasteMenuItem_Click(object? sender, EventArgs e)
    {
        richTextBox1.Paste();
    }

    private void SelectAllMenuItem_Click(object? sender, EventArgs e)
    {
        richTextBox1.SelectAll();
    }

    private void WordWrapMenuItem_CheckedChanged(object? sender, EventArgs e)
    {
        richTextBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
        richTextBox1.ScrollBars = wordWrapToolStripMenuItem.Checked
            ? RichTextBoxScrollBars.Vertical
            : RichTextBoxScrollBars.Both;
    }

    private void FontMenuItem_Click(object? sender, EventArgs e)
    {
        fontDialog1.Font = richTextBox1.Font;

        if (fontDialog1.ShowDialog(this) == DialogResult.OK)
        {
            richTextBox1.Font = fontDialog1.Font;
        }
    }

    private void RichTextBox_TextChanged(object? sender, EventArgs e)
    {
        hasUnsavedChanges = true;
        UpdateTitle();
        UpdateStatus();
        ShowCaretToolTip();
    }

    private void RichTextBox_SelectionChanged(object? sender, EventArgs e)
    {
        richTextBox1.Invalidate();
        UpdateStatus();
        ShowCaretToolTip();
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!ConfirmDiscardChanges())
        {
            e.Cancel = true;
        }
    }

    private void UpdateTitle()
    {
        var fileName = currentFilePath == null ? "Untitled" : Path.GetFileName(currentFilePath);
        var modifiedMark = hasUnsavedChanges ? "*" : string.Empty;
        Text = $"{fileName}{modifiedMark} - Notepad";
    }

    private void UpdateStatus()
    {
        try
        {
            var charIndex = richTextBox1.SelectionStart;
            var line = richTextBox1.GetLineFromCharIndex(charIndex);
            var column = charIndex - richTextBox1.GetFirstCharIndexOfCurrentLine();
            var length = richTextBox1.TextLength;

            statusLabel.Text = $"Ln {line + 1}, Col {column + 1} | {length} chars";
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            statusLabel.Text = "Ready";
        }
    }

    private bool ConfirmDiscardChanges()
    {
        if (!hasUnsavedChanges)
        {
            return true;
        }

        var result = MessageBox.Show(
            this,
            "You have unsaved changes. Do you want to save them before continuing?",
            "Notepad",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1);

        return result switch
        {
            DialogResult.Yes => SaveBeforeContinue(),
            DialogResult.No => true,
            _ => false
        };
    }

    private bool SaveBeforeContinue()
    {
        if (currentFilePath == null)
        {
            return saveFileDialog1.ShowDialog(this) == DialogResult.OK && TrySaveToPath(saveFileDialog1.FileName);
        }

        return TrySaveToPath(currentFilePath);
    }

    private void LoadFile(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLowerInvariant();
        var streamType = extension == ".rtf" ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
        richTextBox1.LoadFile(filePath, streamType);
        currentFilePath = filePath;
        hasUnsavedChanges = false;
        UpdateTitle();
        UpdateStatus();
    }

    private bool TrySaveToPath(string filePath)
    {
        try
        {
            var extension = Path.GetExtension(filePath).ToLowerInvariant();
            var streamType = extension == ".rtf" ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
            richTextBox1.SaveFile(filePath, streamType);
            currentFilePath = filePath;
            hasUnsavedChanges = false;
            UpdateTitle();
            return true;
        }
        catch (Exception ex)
        {
            ShowError("Failed to save file.", ex);
            return false;
        }
    }

    private static void ShowError(string message, Exception ex)
    {
        MessageBox.Show($"{message}{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void ShowCaretToolTip(bool force = false)
    {
        if (!richTextBox1.Focused)
        {
            caretToolTip.Hide(richTextBox1);
            return;
        }

        var caretPosition = richTextBox1.CaretClientPosition;
        if (caretPosition == Point.Empty)
        {
            caretToolTip.Hide(richTextBox1);
            return;
        }

        if (!showCaretTooltip)
        {
            caretToolTip.Hide(richTextBox1);
            return;
        }

        var now = DateTime.UtcNow;
        if (!force && (now - lastCaretTooltipShown).TotalMilliseconds < 120)
        {
            return;
        }

        caretToolTip.Show(statusLabel.Text, richTextBox1, caretPosition.X + 16, caretPosition.Y + 28, 800);
        lastCaretTooltipShown = now;
    }

    private void AnimatedCaretMenuItem_CheckedChanged(object? sender, EventArgs e)
    {
        richTextBox1.ShowCaretGlow = animatedCaretToolStripMenuItem.Checked;
        richTextBox1.Invalidate();
    }

    private void CaretGuidesMenuItem_CheckedChanged(object? sender, EventArgs e)
    {
        richTextBox1.ShowCaretGuideLines = caretGuidesToolStripMenuItem.Checked;
        richTextBox1.Invalidate();
    }

    private void CaretTooltipMenuItem_CheckedChanged(object? sender, EventArgs e)
    {
        showCaretTooltip = caretTooltipToolStripMenuItem.Checked;
        if (!showCaretTooltip)
        {
            caretToolTip.Hide(richTextBox1);
        }
        else
        {
            ShowCaretToolTip(force: true);
        }
    }
}
