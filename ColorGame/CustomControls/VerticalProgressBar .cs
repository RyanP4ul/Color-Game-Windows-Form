using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.CustomControls
{
    internal class VerticalProgressBar : Panel
    {

        private Panel fillPanel;
        private int progress = 0;

        [Browsable(true)]
        [Category("Behavior")]
        [Description("Current progress value (0-100)")]
        public int Progress
        {
            get => progress;
            set
            {
                progress = Math.Max(0, Math.Min(100, value));
                UpdateFill();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Fill color of the progress bar")]
        public Color FillColor
        {
            get => fillPanel.BackColor;
            set => fillPanel.BackColor = value;
        }

        public VerticalProgressBar()
        {
            this.BackColor = Color.Gray;
            this.BorderStyle = BorderStyle.FixedSingle;

            fillPanel = new Panel
            {
                BackColor = Color.Lime,
                Width = this.Width,
                Height = 0,
                Dock = DockStyle.None
            };

            this.Controls.Add(fillPanel);
            this.Resize += (s, e) => UpdateFill();
        }

        private void UpdateFill()
        {
            int fillHeight = (int)(this.Height * (progress / 100.0));
            fillPanel.SetBounds(0, this.Height - fillHeight, this.Width, fillHeight);
        }

    }
}
