using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.CustomControls
{
    public class CustomPanel : Panel
    {

        public int CornerRadius { get; set; } = 20;
        public Color GradientColor1 { get; set; } = Color.LightBlue;
        public Color GradientColor2 { get; set; } = Color.DarkBlue;
        public float GradientAngle { get; set; } = 45f;

        // Opacity (0 = fully transparent, 255 = fully opaque)
        public int Opacity { get; set; } = 180;

        // Border properties
        public Color BorderColor { get; set; } = Color.Black;
        public float BorderThickness { get; set; } = 2f;

        public CustomPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundedRectPath(rect, CornerRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(Opacity, GradientColor1),
                Color.FromArgb(Opacity, GradientColor2),
                GradientAngle))

                if (Opacity > 0 || BorderThickness > 0)
                {
                    using (Pen borderPen = new Pen(BorderColor, BorderThickness))
                    {
                        // Fill background with gradient and opacity
                        e.Graphics.FillPath(brush, path);

                        // Draw border
                        e.Graphics.DrawPath(borderPen, path);
                    }
                }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);                         // Top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);         // Top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);         // Bottom-left
            path.CloseFigure();

            return path;
        }

    }
}
