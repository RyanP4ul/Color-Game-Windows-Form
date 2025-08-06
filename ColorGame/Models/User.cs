using ColorGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.Models
{
    public class User : GameStatistics
    {

        private static User? _instance;

        // SINCE THIS IS A SINGLE PLAYER GAME, WE CAN USE A SINGLETON PATTERN FOR THE USER CLASS
        public static User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }
        }

        public User()
        {
            // TEMPORAY FOR DEMO PURPOSE ONLY
            var transaction_1 = new Transaction();
            transaction_1.id = Guid.NewGuid().ToString("N");
            transaction_1.Amount = 500;
            transaction_1.Type = TransactionTypeEnum.Withdrawal;
            transaction_1.PaymentMethod = PaymentMethodEnum.GCash;
            transaction_1.TransactionDate = DateTime.Now;
            Transactions.Add(transaction_1.id, transaction_1);
        }

        public int Balance { get; set; } = 10000;
        public int GameWallet { get; set; } = 5000;
        public PaymentMethodEnum PaymentMethod { get; set; } = PaymentMethodEnum.GCash;
        public DateTime LastTransaction { get; set; } = DateTime.Now;
        public Dictionary<string, Transaction> Transactions = new Dictionary<string, Transaction>();

    }
}
