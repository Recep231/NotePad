namespace NotePadApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private Controls.EnhancedRichTextBox richTextBox1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem animatedCaretToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem caretGuidesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem caretTooltipToolStripMenuItem;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.richTextBox1 = new NotePadApp.Controls.EnhancedRichTextBox();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        this.fontDialog1 = new System.Windows.Forms.FontDialog();
        this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.animatedCaretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.caretGuidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.caretTooltipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
        this.menuStrip1.Size = new System.Drawing.Size(900, 35);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
        this.fileToolStripMenuItem.Text = "File";
        // 
        // newToolStripMenuItem
        // 
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        this.newToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
        this.newToolStripMenuItem.Text = "New";
        this.newToolStripMenuItem.Click += new System.EventHandler(this.NewFileMenuItem_Click);
        // 
        // openToolStripMenuItem
        // 
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        this.openToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
        this.openToolStripMenuItem.Text = "Open...";
        this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
        // 
        // saveToolStripMenuItem
        // 
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        this.saveToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
        this.saveToolStripMenuItem.Text = "Save";
        this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
        // 
        // saveAsToolStripMenuItem
        // 
        this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
        this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
        this.saveAsToolStripMenuItem.Text = "Save As...";
        this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsMenuItem_Click);
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
        // 
        // editToolStripMenuItem
        // 
        this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
        this.editToolStripMenuItem.Text = "Edit";
        // 
        // undoToolStripMenuItem
        // 
        this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
        this.undoToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.undoToolStripMenuItem.Text = "Undo";
        this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
        // 
        // redoToolStripMenuItem
        // 
        this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
        this.redoToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.redoToolStripMenuItem.Text = "Redo";
        this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoMenuItem_Click);
        // 
        // toolStripSeparator2
        // 
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
        // 
        // cutToolStripMenuItem
        // 
        this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
        this.cutToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.cutToolStripMenuItem.Text = "Cut";
        this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
        // 
        // copyToolStripMenuItem
        // 
        this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        this.copyToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.copyToolStripMenuItem.Text = "Copy";
        this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
        // 
        // pasteToolStripMenuItem
        // 
        this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
        this.pasteToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.pasteToolStripMenuItem.Text = "Paste";
        this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
        // 
        // selectAllToolStripMenuItem
        // 
        this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
        this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
        this.selectAllToolStripMenuItem.Text = "Select All";
        this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
        // 
        // formatToolStripMenuItem
        // 
        this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
        this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
        this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
        this.formatToolStripMenuItem.Text = "Format";
        // 
        // viewToolStripMenuItem
        // 
        this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animatedCaretToolStripMenuItem,
            this.caretGuidesToolStripMenuItem,
            this.caretTooltipToolStripMenuItem});
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
        this.viewToolStripMenuItem.Text = "View";
        // 
        // animatedCaretToolStripMenuItem
        // 
        this.animatedCaretToolStripMenuItem.Checked = true;
        this.animatedCaretToolStripMenuItem.CheckOnClick = true;
        this.animatedCaretToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.animatedCaretToolStripMenuItem.Name = "animatedCaretToolStripMenuItem";
        this.animatedCaretToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
        this.animatedCaretToolStripMenuItem.Text = "Animated Caret Glow";
        this.animatedCaretToolStripMenuItem.CheckedChanged += new System.EventHandler(this.AnimatedCaretMenuItem_CheckedChanged);
        // 
        // caretGuidesToolStripMenuItem
        // 
        this.caretGuidesToolStripMenuItem.Checked = true;
        this.caretGuidesToolStripMenuItem.CheckOnClick = true;
        this.caretGuidesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.caretGuidesToolStripMenuItem.Name = "caretGuidesToolStripMenuItem";
        this.caretGuidesToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
        this.caretGuidesToolStripMenuItem.Text = "Caret Guide Lines";
        this.caretGuidesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CaretGuidesMenuItem_CheckedChanged);
        // 
        // caretTooltipToolStripMenuItem
        // 
        this.caretTooltipToolStripMenuItem.Checked = true;
        this.caretTooltipToolStripMenuItem.CheckOnClick = true;
        this.caretTooltipToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.caretTooltipToolStripMenuItem.Name = "caretTooltipToolStripMenuItem";
        this.caretTooltipToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
        this.caretTooltipToolStripMenuItem.Text = "Floating Caret Tooltip";
        this.caretTooltipToolStripMenuItem.CheckedChanged += new System.EventHandler(this.CaretTooltipMenuItem_CheckedChanged);
        // 
        // wordWrapToolStripMenuItem
        // 
        this.wordWrapToolStripMenuItem.Checked = true;
        this.wordWrapToolStripMenuItem.CheckOnClick = true;
        this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
        this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
        this.wordWrapToolStripMenuItem.Text = "Word Wrap";
        this.wordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.WordWrapMenuItem_CheckedChanged);
        // 
        // fontToolStripMenuItem
        // 
        this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
        this.fontToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
        this.fontToolStripMenuItem.Text = "Font...";
        this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontMenuItem_Click);
        // 
        // statusStrip1
        // 
        this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
        this.statusStrip1.Location = new System.Drawing.Point(0, 575);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
        this.statusStrip1.Size = new System.Drawing.Size(900, 30);
        this.statusStrip1.TabIndex = 2;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // statusLabel
        // 
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new System.Drawing.Size(137, 23);
        this.statusLabel.Text = "Ln 1, Col 1 | 0 chars";
        // 
        // richTextBox1
        // 
        this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.richTextBox1.HideSelection = false;
        this.richTextBox1.Location = new System.Drawing.Point(0, 35);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(900, 540);
        this.richTextBox1.TabIndex = 1;
        this.richTextBox1.Text = "";
        this.richTextBox1.SelectionChanged += new System.EventHandler(this.RichTextBox_SelectionChanged);
        this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
        this.openFileDialog1.Title = "Open";
        // 
        // saveFileDialog1
        // 
        this.saveFileDialog1.DefaultExt = "txt";
        this.saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
        this.saveFileDialog1.Title = "Save As";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 605);
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Form1";
        this.Text = "Notepad";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
