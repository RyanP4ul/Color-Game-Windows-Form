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

namespace ColorGame.Forms
{
    public partial class DialogBetForm : Form
    {

        private string _activeButton = string.Empty;
        public int ResultStatus { get; private set; } = 0; // ResultStatus 0 = Fail, 1 = Ok

        public DialogBetForm() => InitializeComponent();

        private void DialogBetForm_Load(object sender, EventArgs e)
        {
            if (Parent == null) return;

            this.Location = new Point((Parent.ClientSize.Width - this.Width) / 2, (Parent.ClientSize.Height - this.Height) / 2);

            btnRemoveBet.Visible = false;

            textBoxAmount.Focus();
        }

        public void Init(int currentBalance, int amount)
        {
            textBoxAmount.Focus();
            textBoxAmount.Text = amount.ToString();
            btnRemoveBet.Visible = amount > 0;
            labelCurrentBalance.Text = $"Current Balance: {currentBalance.ToString("N0")}";
        }

        public int Amount
        {
            get
            {
                if (string.IsNullOrEmpty(textBoxAmount.Text)) return 0;

                try
                {
                    return Convert.ToInt32(textBoxAmount.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("RICH ALERT! Do you even have that money?", "RICH ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxAmount.Text = textBoxAmount.Text.Substring(0, textBoxAmount.Text.Length - 1);
                    return int.MaxValue;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public void SetAmount(int amount)
        {
            textBoxAmount.Text = amount.ToString("N0");
            refreshButtons();
        }

        public void ButtonClick(CustomButton button, string amount)
        {
            Utils.PlayButtonSound();
            textBoxAmount.Focus();
            textBoxAmount.Text = amount;
            ButtonActive(button);
            refreshButtons();
            _activeButton = button.Name;
        }

        public void ButtonActive(CustomButton button)
        {
            button.ForeColor = Color.White;
            button.GradientColor1 = Color.DarkSalmon;
            button.GradientColor2 = Color.LightCoral;
        }

        public void ButtonDefault(CustomButton button)
        {
            if (_activeButton == button.Name) return;

            button.ForeColor = Color.Black;
            button.GradientColor1 = Color.WhiteSmoke;
            button.GradientColor2 = Color.FromArgb(229, 231, 235);
        }

        private void refreshButtons()
        {
            _activeButton = string.Empty;
            var betAmount = Amount;

            // CHECK EVERY CHILDS
            foreach (var ctrl in Controls)
            {
                // CHECK IF THE CONTROL IS A CUSTOM BUTTON AND HAVE TAG "Bet" TO PREVENT CALLING OTHER CUSTOM BUTTONS
                if (ctrl is CustomButton button && !string.IsNullOrEmpty(button.Tag?.ToString() ?? ""))
                {
                    // SINCE SOME BUTTON CONTAIN COMMAS, WE NEED TO REPLACE THEM TO BLANK TO CONVERT IT TO INT
                    var amount = Convert.ToInt32(button.Text.Replace(",", ""));

                    if (betAmount == amount)
                    {
                        ButtonActive(button);
                    }
                    else
                    {
                        ButtonDefault(button);
                    }
                }
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e) => refreshButtons();

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnQuickSelect1_Click(object sender, EventArgs e) => ButtonClick(btnQuickSelect1, "500");
        private void btnQuickSelect1_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect1);
        private void btnQuickSelect1_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect1);

        private void btnQuickSelect2_Click(object sender, EventArgs e) => ButtonClick(btnQuickSelect2, "1000");
        private void btnQuickSelect2_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect2);
        private void btnQuickSelect2_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect2);

        private void btnQuickSelect3_Click(object sender, EventArgs e) => ButtonClick(btnQuickSelect3, "5000");
        private void btnQuickSelect3_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect3);
        private void btnQuickSelect3_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect3);

        private void btnQuickSelect4_MouseClick(object sender, MouseEventArgs e) => ButtonClick(btnQuickSelect4, "10000");
        private void btnQuickSelect4_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect4);
        private void btnQuickSelect4_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect4);

        private void btnQuickSelect5_Click(object sender, EventArgs e) => ButtonClick(btnQuickSelect5, "20000");
        private void btnQuickSelect5_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect5);
        private void btnQuickSelect5_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect5);

        private void btnQuickSelect6_MouseClick(object sender, MouseEventArgs e) => ButtonClick(btnQuickSelect6, "30000");
        private void btnQuickSelect6_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect6);
        private void btnQuickSelect6_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect6);

        private void btnQuickSelect7_MouseClick(object sender, MouseEventArgs e) => ButtonClick(btnQuickSelect7, "50000");
        private void btnQuickSelect7_MouseHover(object sender, EventArgs e) => ButtonActive(btnQuickSelect7);
        private void btnQuickSelect7_MouseLeave(object sender, EventArgs e) => ButtonDefault(btnQuickSelect7);

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnApply_Click(object sender, EventArgs e)
        {
            Utils.PlayButtonSound();
            ResultStatus = 1;
            Close();
        }

        private void btnRemoveBet_Click(object sender, EventArgs e)
        {
            Utils.PlayButtonSound();
            ResultStatus = 2;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
