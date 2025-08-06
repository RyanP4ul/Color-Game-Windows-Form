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
    public partial class TransactionForm : Form
    {

        private int amount = 0;
        private TransactionTypeEnum transactionType;

        public TransactionForm()
        {
            InitializeComponent();
        }

        public void Init(int newAmount, TransactionTypeEnum newType)
        {
            amount = newAmount;
            transactionType = newType;
            labelTransactionType.Text = transactionType == TransactionTypeEnum.Withdrawal ? "Withdrawal" : "Deposit";
            labelPaymentMethod.Text = User.Instance.PaymentMethod == PaymentMethodEnum.GCash ? "GCash" : "Paypal";
            labelAmount.Text = $"₱{amount}";
            labelGameCoinsToReceived.Text = (amount * 10).ToString("N0");
            labelTotal.Text = amount.ToString();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (Parent is WithdrawAndDepositForm form)
            {
                form.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        private void pictureBoxClose_Click(object sender, EventArgs e) => Close();
        private void pictureBoxClose_MouseEnter(object sender, EventArgs e) => Cursor = Cursors.Hand;
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["WalletForm"] is WalletForm walletForm)
            {
                if (transactionType == TransactionTypeEnum.Withdrawal)
                {
                    User.Instance.GameWallet -= amount * 10;
                    User.Instance.Balance += amount;
                }
                else if (transactionType == TransactionTypeEnum.Deposit)
                {
                    User.Instance.GameWallet += amount * 10;
                    User.Instance.Balance -= amount;
                }

                Transaction transaction = new Transaction();

                transaction.id = Guid.NewGuid().ToString("N");
                transaction.Amount = amount;
                transaction.Type = transactionType;
                transaction.PaymentMethod = User.Instance.PaymentMethod;
                transaction.TransactionDate = DateTime.Now;

                User.Instance.Transactions.Add(transaction.id, transaction);

                walletForm.RefreshCurrency();
                walletForm.AddTransaction(transaction);

                var modal = new TransactionResultForm();
                var overlay = Utils.OverlayForm(this);
                overlay.Show();

                if (transactionType == TransactionTypeEnum.Withdrawal)
                {
                    modal.SetMessage($"Your withdraw of ₱{amount} via {labelPaymentMethod.Text} has been processed.", $"{amount * 10} coins added to your game account!");
                }
                else if (transactionType == TransactionTypeEnum.Deposit)
                {
                    modal.SetMessage($"Your deposit of ₱{amount} via {labelPaymentMethod.Text}", $"{amount * 10} coins deducted from your game account.");
                }

                modal.ShowInTaskbar = false;
                modal.StartPosition = FormStartPosition.CenterParent;
                modal.ShowDialog(this);
                overlay.Close();
            }

            Close();
        }
    }
}
