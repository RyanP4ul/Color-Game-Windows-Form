using ColorGame.Enums;
using ColorGame.Models;
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
    public partial class WithdrawAndDepositForm : Form
    {

        private TransactionTypeEnum transactionType;

        public WithdrawAndDepositForm()
        {
            InitializeComponent();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            var paymentMethod = User.Instance.PaymentMethod == Enums.PaymentMethodEnum.GCash ? "GCash" : "Paypal";
            labelPaymentMethod.Text = $"Payment Method: {paymentMethod}";
            pictureBoxPaymentMethod.Image = Utils.LoadImage($"{paymentMethod}.png");
            labelAvailable.Text = $"Available game coins: ₱{User.Instance.GameWallet}";
        }

        public void Init(TransactionTypeEnum newTransactionType)
        {
            transactionType = newTransactionType;

            if (transactionType == TransactionTypeEnum.Withdrawal)
            {
                labelTransactionType.Text = "Withdraw";
                labelApproximately.Text = " You'll spend approximately 0 game coins";
                btnAction.Text = "Withdraw";
            }
            else
            {
                labelTransactionType.Text = "Deposit";
                labelApproximately.Text = " You'll receive approximately 0 game coins";
                btnAction.Text = "Deposit";
            }
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
                    textBoxAmount.Text = textBoxAmount.Text.Substring(0, textBoxAmount.Text.Length - 1);
                    return int.MaxValue;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (Amount > 10)
            {
                labelApproximately.Text = $"You'll {(transactionType == TransactionTypeEnum.Withdrawal ? "spend" : "received")} approximately {Amount * 10} game coins";
            }
        }

        private void btnQuickSelect1_Click(object sender, EventArgs e) => textBoxAmount.Text = "500";
        private void btnQuickSelect2_Click(object sender, EventArgs e) => textBoxAmount.Text = "1000";
        private void btnQuickSelect3_Click(object sender, EventArgs e) => textBoxAmount.Text = "2000";
        private void btnQuickSelect4_Click(object sender, EventArgs e) => textBoxAmount.Text = "3000";
        private void btnQuickSelect5_Click(object sender, EventArgs e) => textBoxAmount.Text = "5000";
        private void btnQuickSelect6_Click(object sender, EventArgs e) => textBoxAmount.Text = "10000";

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (transactionType == TransactionTypeEnum.Deposit && User.Instance.Balance < Amount)
            {
                MessageBox.Show($"Insufficient Balance.", "Broke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (transactionType == TransactionTypeEnum.Withdrawal && User.Instance.GameWallet < Amount * 10)
            {
                MessageBox.Show($"Insufficient Game Wallet.", "Broke", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Amount < 50)
            {
                MessageBox.Show("Minimum amount to withdraw is 50 game coins.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Amount > 50000)
            {
                MessageBox.Show("Maximum amount to withdraw is 50,000 game coins.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modal = new TransactionForm();

            var overlay = Utils.OverlayForm(this);

            overlay.Show();
            modal.Init(Amount, transactionType);
            modal.ShowInTaskbar = false;
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog(this);

            overlay.Close();

            Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) => Close();
        private void pictureBoxClose_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
    }
}
