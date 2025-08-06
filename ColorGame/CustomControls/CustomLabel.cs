using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.CustomControls
{

    [ToolboxBitmap(typeof(Label))] // Show label icon in toolbox
    [DesignerCategory("Code")]     // Improve compatibility
    public class CustomLabel : Label
    {

        private Color glowColor = Color.Cyan;
        private int glowSize = 6;

        public CustomLabel()
        {
            // Enable double buffering for smoother rendering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            this.AutoSize = false;
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The color of the glow effect.")]
        public Color GlowColor
        {
            get => glowColor;
            set
            {
                glowColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The thickness of the glow effect.")]
        public int GlowSize
        {
            get => glowSize;
            set
            {
                glowSize = Math.Max(1, value);
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            string text = this.Text;
            Font font = this.Font;
            Color foreColor = this.ForeColor;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };

                path.AddString(text, font.FontFamily, (int)font.Style,
                               g.DpiY * font.Size / 72,
                               this.ClientRectangle, sf);

                // Glow effect
                for (int i = glowSize; i >= 1; i--)
                {
                    using (Pen pen = new Pen(Color.FromArgb(30, glowColor), i))
                    {
                        pen.LineJoin = LineJoin.Round;
                        g.DrawPath(pen, path);
                    }
                }

                // Fill the main text
                using (SolidBrush brush = new SolidBrush(foreColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }


    }
}
