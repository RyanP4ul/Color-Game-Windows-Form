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
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();
        }

        private void WalletForm_Load(object sender, EventArgs e)
        {
            labelCurrentBalance.Text = User.Instance.Balance.ToString("N0");
            labelGameWallet.Text = User.Instance.GameWallet.ToString("N0");
            labelLastTransaction.Text = $"Last updated: {User.Instance.LastTransaction.ToString("MMMM dd, yyyy - hh:mm tt")}";
            customPictureBoxPayment.Image = Utils.LoadImage(User.Instance.PaymentMethod == Enums.PaymentMethodEnum.GCash ? "RoundedGCash.png" : "RoundedPaypal.png");

            if (User.Instance.Transactions.Count > 0)
            {
                flowLayoutPanelTransactionHistory.AutoScroll = true;
                flowLayoutPanelTransactionHistory.Padding = new Padding(5);

                foreach (Transaction transaction in User.Instance.Transactions.Values)
                {
                    TransactionUserControl transactionControl = new TransactionUserControl();
                    transactionControl.Init(transaction);
                    flowLayoutPanelTransactionHistory.Controls.Add(transactionControl);
                }
            }
        }

        public void RefreshCurrency()
        {
            labelCurrentBalance.Text = User.Instance.Balance.ToString("N0");
            labelGameWallet.Text = User.Instance.GameWallet.ToString("N0");
        }

        public void AddTransaction(Transaction transaction)
        {
            TransactionUserControl transactionControl = new TransactionUserControl();
            transactionControl.Init(transaction);
            flowLayoutPanelTransactionHistory.Controls.Add(transactionControl);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowTransactionForm(Enums.TransactionTypeEnum transactionType)
        {
            var modal = new WithdrawAndDepositForm();
            var overlay = Utils.OverlayForm(this);
            overlay.Show();
            modal.Init(transactionType);
            modal.ShowInTaskbar = false;
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog(this);
            overlay.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e) => ShowTransactionForm(Enums.TransactionTypeEnum.Withdrawal);
        private void btnDeposit_Click(object sender, EventArgs e) => ShowTransactionForm(Enums.TransactionTypeEnum.Deposit);
    }
}
