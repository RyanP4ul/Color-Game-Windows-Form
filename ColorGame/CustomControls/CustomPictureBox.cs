using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.CustomControls
{

    [ToolboxBitmap(typeof(PictureBox))]
    [DesignerCategory("Code")]
    public class CustomPictureBox : PictureBox
    {
        private Color glowColor = Color.Cyan;
        private int glowSize = 6;
        private int opacity = 100; // Range: 0–100

        public CustomPictureBox()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The color of the glow effect.")]
        public Color GlowColor
        {
            get => glowColor;
            set { glowColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The size of the glow effect.")]
        public int GlowSize
        {
            get => glowSize;
            set { glowSize = Math.Max(0, value); Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The opacity level (0-100).")]
        public int Opacity
        {
            get => opacity;
            set
            {
                opacity = Math.Min(100, Math.Max(0, value));
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (Image == null) return;

            Rectangle rect = new Rectangle(GlowSize, GlowSize, Width - GlowSize * 2, Height - GlowSize * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);

                // Glow
                for (int i = GlowSize; i > 0; i--)
                {
                    using (Pen pen = new Pen(Color.FromArgb(15, glowColor), i * 2))
                    {
                        pen.LineJoin = LineJoin.Round;
                        g.DrawPath(pen, path);
                    }
                }
            }

            // Image with opacity
            ColorMatrix matrix = new ColorMatrix
            {
                Matrix33 = opacity / 100f // Opacity: 1.0 = fully visible
            };

            using (ImageAttributes attributes = new ImageAttributes())
            {
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(Image, rect, 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, attributes);
            }
        }
    }
}
