using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame.Forms
{
    public partial class ColorModeForm : Form
    {

        private Bitmap cachedBackground;

        public ColorModeForm()
        {
            InitializeComponent();

            cachedBackground = new Bitmap("C:\\Users\\ryanpaul\\source\\repos\\ColorGame\\ColorGame\\Images\\Background.png");
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (cachedBackground != null)
            {
                e.Graphics.DrawImage(cachedBackground, 0, 0, ClientSize.Width, ClientSize.Height);
            }
        }

    }
}
