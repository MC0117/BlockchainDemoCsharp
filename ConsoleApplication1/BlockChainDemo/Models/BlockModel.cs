using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockChainDemo.Models;

namespace BlockChainDemo
{
    class Block
    {
        private int PreviousHash { get; set; }
        private int CurrentHash { get; set; }
        List<Transaction> Transactions;
        
        
        public Block(int previousHash, List<Transaction> transactions)
        {
            PreviousHash = previousHash;
            Transactions = transactions;

            Object[] BlockData = new Object[2] { PreviousHash, Transactions.GetHashCode() };
            CurrentHash = BlockData.GetHashCode();
        }

        public int GetPreviousHash()
        {
            return PreviousHash;
        }
        public int GetCurrentHash()
        {
            return CurrentHash;
        }
    }
}
