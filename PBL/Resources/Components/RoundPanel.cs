using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class RoundPanel : Panel
{
    #region Corner Radius
    private int cornerRadius = 10;

    public int CornerRadius
    {
        get { return cornerRadius; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Corner radius cannot be negative.");

            cornerRadius = value;
            Invalidate(); // Redraw the panel when the corner radius changes
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a GraphicsPath to define the rounded shape
        using (GraphicsPath path = new GraphicsPath())
        {
            int margin = 1; // Adjust this value to control the margin between the border and the content

            Rectangle rect = new Rectangle(margin, margin, Width - margin * 2, Height - margin * 2);
            int diameter = cornerRadius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the panel's region to the rounded shape defined by the GraphicsPath
            Region = new Region(path);

            // Fill the rounded panel with the desired background color
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }
    #endregion
}