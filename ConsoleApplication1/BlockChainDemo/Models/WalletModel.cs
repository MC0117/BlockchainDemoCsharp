using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainDemo.Models
{
    class WalletModel
    {
        public string WalletAdress { get; set; }
        public double Balance { get; set; }
        public double TotalIn { get; set; }
        public double TotalOut { get; set; }

        public bool PossibleTransaction(double Payment)
        {
            if (Balance >= Payment)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
