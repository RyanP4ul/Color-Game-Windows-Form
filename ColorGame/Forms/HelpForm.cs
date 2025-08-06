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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        private void btnClose_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void btnClose_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
        private void pictureBoxClose_Click(object sender, EventArgs e) => Close();
        private void pictureBoxClose_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

    }
}
