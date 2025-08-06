using ColorGame.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class MsgUserControl : UserControl
    {

        private CustomLabel labelMsg;
        int targetX = 0; // Final position (X) for the label
        int speed = 5;     // How fast it moves

        public MsgUserControl()
        {
            InitializeComponent();

            labelMsg = new CustomLabel();
            labelMsg.AutoSize = false;
            labelMsg.TextAlign = ContentAlignment.MiddleCenter;
            labelMsg.Font = new Font("Space Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMsg.Location = new Point(100, 15);
            labelMsg.Size = new Size(200, 28);
            labelMsg.ForeColor = Color.White;
            labelMsg.Text = "YOU WON!";
            labelMsg.BackColor = Color.Transparent;
            labelMsg.GlowColor = Color.Black;
            labelMsg.GlowSize = 7;
            labelMsg.Parent = popMsg;
            popMsg.Controls.Add(labelMsg);

            timerSlide.Start();
        }

        public void SetMsg(string msg)
        {
            labelMsg.Location = new Point(100, 15);
            labelMsg.Text = msg;
            timerSlide.Start();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (popMsg.Bounds.IntersectsWith(labelMsg.Bounds))
            {
                labelMsg.Left += speed; // Move label to the right
            }
            else
            {
                timerSlide.Stop();
                this.Hide();
            }
        }
    }
}
