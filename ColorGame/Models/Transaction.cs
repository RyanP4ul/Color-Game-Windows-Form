using ColorGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.Models
{
    public class Transaction
    {

        public string id { get; set; }
        public int Amount { get; set; } = 0;
        public TransactionTypeEnum Type { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
