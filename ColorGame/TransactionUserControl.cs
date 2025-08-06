using ColorGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class TransactionUserControl : UserControl
    {

        public TransactionUserControl()
        {
            InitializeComponent();
        }

        public void Init(Transaction transaction)
        {
            if (transaction.Type == Enums.TransactionTypeEnum.Withdrawal)
            {
                pictureBoxTransactionType.Image = Utils.LoadImage("TransactionCashOut.png");
                labelTransactionType.Text = "Cash Out";
                labelAmount.Text = $"+₱{transaction.Amount.ToString("N0")}";
                labelAmount.ForeColor = Color.FromArgb(22, 163, 74);
            }
            else
            {
                pictureBoxTransactionType.Image = Utils.LoadImage("TransactionBuy.png");
                labelTransactionType.Text = "Buy";
                labelAmount.Text = $"-₱{transaction.Amount.ToString("N0")}";
                labelAmount.ForeColor = Color.FromArgb(37, 99, 235);
            }

            labelVia.Text = transaction.PaymentMethod == Enums.PaymentMethodEnum.GCash ? "Via GCash" : "Via PayPal";
            labelTransactionDate.Text = transaction.TransactionDate.ToString("yyyy-MM-dd • HH:mm");
        }

    }
}
