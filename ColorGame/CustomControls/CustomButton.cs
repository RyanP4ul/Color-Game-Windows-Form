using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorGame.CustomControls
{
    public class CustomButton : Button
    {
        public int CornerRadius { get; set; } = 20;
        public Color GradientColor1 { get; set; } = Color.MediumSlateBlue;
        public Color GradientColor2 { get; set; } = Color.MediumPurple;
        public float GradientAngle { get; set; } = 45f;

        public int GlowSize { get; set; } = 8;
        public Color GlowColor { get; set; } = Color.Cyan;

        public bool EnableHover { get; set; } = false;
        public Color HoverOverlayColor { get; set; } = Color.FromArgb(80, Color.White); // Transparent white
        private bool isHovered = false;


        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;

            // Draw glow
            if (GlowSize > 0)
            {
                Rectangle glowRect = new Rectangle(
                    rect.X - GlowSize,
                    rect.Y - GlowSize,
                    rect.Width + GlowSize * 2,
                    rect.Height + GlowSize * 2
                );

                using (GraphicsPath glowPath = GetRoundedRectPath(glowRect, CornerRadius + GlowSize))
                using (PathGradientBrush glowBrush = new PathGradientBrush(glowPath))
                {
                    glowBrush.CenterColor = Color.FromArgb(180, GlowColor);
                    glowBrush.SurroundColors = new Color[] { Color.FromArgb(0, GlowColor) };
                    pevent.Graphics.FillPath(glowBrush, glowPath);
                }
            }

            // Draw button gradient background
            using (GraphicsPath path = GetRoundedRectPath(rect, CornerRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, GradientColor1, GradientColor2, GradientAngle))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {

                // Transparent hover overlay
                if (EnableHover && isHovered)
                {
                    using (SolidBrush hoverBrush = new SolidBrush(HoverOverlayColor))
                    {
                        pevent.Graphics.FillPath(hoverBrush, path);
                    }
                }
                else
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                // Draw text
                TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Cursor = Cursors.Hand;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Cursor = Cursors.Default;
            Invalidate();
        }

    }
}
