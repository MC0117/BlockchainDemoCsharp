using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainDemo.Models
{
    class Transaction
    {
        public string TransactionID { get; set; } // TransactionID is the ID of the specific transaction
        public WalletModel WalletSender; // Wallet where the coins are going to be sent from
        public WalletModel WalletRecipient; // Wallet where the coins are going to be sent to
        public double Payment { get; set; } // The amount of coins that are going to be moved

        public void TransferCoins(double Payment)
        {
            if (WalletSender.Balance >= Payment)
            {
                WalletSender.Balance -= Payment;
                WalletSender.TotalOut += Payment;

                WalletRecipient.Balance += Payment;
                WalletRecipient.TotalIn += Payment;
            }
            else
            {
                Console.WriteLine("You do not have enough coins to complete this transaction");
            }
        }
    }
}
