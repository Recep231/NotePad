using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotePadApp.Controls;

public class EnhancedRichTextBox : RichTextBox
{
    private const int WM_PAINT = 0x000F;

    private readonly System.Windows.Forms.Timer caretTimer;
    private float glowPhase;
    private Point caretClientPosition = Point.Empty;
    private Rectangle lastCaretInvalidate = Rectangle.Empty;

    public EnhancedRichTextBox()
    {
        caretTimer = new System.Windows.Forms.Timer
        {
            Interval = 33
        };
        caretTimer.Tick += (_, _) => OnCaretTimerTick();

        BorderStyle = BorderStyle.None;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Color CaretGlowColor { get; set; } = Color.FromArgb(120, 0, 120, 215);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool ShowCaretGlow { get; set; } = true;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool ShowCaretGuideLines { get; set; } = true;

    public Point CaretClientPosition => caretClientPosition;

    private bool IsInDesignMode => LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        if (!IsInDesignMode)
        {
            caretTimer.Start();
        }
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        base.OnHandleDestroyed(e);
        caretTimer.Stop();
    }

    protected override void OnGotFocus(EventArgs e)
    {
        base.OnGotFocus(e);
        if (!IsInDesignMode)
        {
            caretTimer.Start();
        }
    }

    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);
        caretTimer.Stop();
        InvalidateCaretArea();
        caretClientPosition = Point.Empty;
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == WM_PAINT)
        {
            using var graphics = Graphics.FromHwnd(Handle);
            DrawCaretGuides(graphics);
            DrawCaretGlow(graphics);
        }
    }

    private void OnCaretTimerTick()
    {
        if (IsInDesignMode)
        {
            return;
        }

        UpdateCaretPosition();
        glowPhase += 0.2f;
        if (glowPhase > Math.PI * 2)
        {
            glowPhase -= (float)(Math.PI * 2);
        }

        InvalidateCaretArea();
    }

    private void UpdateCaretPosition()
    {
        if (IsInDesignMode)
        {
            caretClientPosition = Point.Empty;
            return;
        }

        if (Focused && NativeMethods.GetCaretPos(out var caretPos))
        {
            caretClientPosition = caretPos;
        }
        else
        {
            caretClientPosition = Point.Empty;
        }
    }

    private void DrawCaretGuides(Graphics graphics)
    {
        if (!ShowCaretGuideLines || caretClientPosition.IsEmpty)
        {
            return;
        }

        using var pen = new Pen(Color.FromArgb(40, CaretGlowColor), 1f)
        {
            DashStyle = DashStyle.Dot
        };

        graphics.DrawLine(pen, 0, caretClientPosition.Y, ClientSize.Width, caretClientPosition.Y);
        graphics.DrawLine(pen, caretClientPosition.X, 0, caretClientPosition.X, ClientSize.Height);
    }

    private void DrawCaretGlow(Graphics graphics)
    {
        if (!ShowCaretGlow || caretClientPosition.IsEmpty)
        {
            return;
        }

        var radius = 12f + (float)Math.Sin(glowPhase) * 3f;
        var glowRect = new RectangleF(
            caretClientPosition.X - radius,
            caretClientPosition.Y - radius,
            radius * 2,
            radius * 2);

        using var path = new GraphicsPath();
        path.AddEllipse(glowRect);

        using var brush = new PathGradientBrush(path)
        {
            CenterColor = Color.FromArgb(160, CaretGlowColor),
            SurroundColors = new[] { Color.FromArgb(0, CaretGlowColor) }
        };

        graphics.FillPath(brush, path);
    }

    private void InvalidateCaretArea()
    {
        if (IsDisposed)
        {
            return;
        }

        var area = caretClientPosition.IsEmpty
            ? lastCaretInvalidate
            : new Rectangle(
                caretClientPosition.X - 30,
                caretClientPosition.Y - 30,
                60,
                60);

        if (!area.IsEmpty)
        {
            Invalidate(area, false);
            lastCaretInvalidate = area;
        }
    }

    private static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern bool GetCaretPos(out Point lpPoint);
    }
}

