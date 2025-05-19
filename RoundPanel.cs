using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 30; // Adjustable corner radius
    public Color BorderColor { get; set; } = Color.Black; // Border color
    public int BorderThickness { get; set; } = 2; // Border thickness

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // Apply rounded shape

            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path); // Draw border
            }
        }
    }
}
