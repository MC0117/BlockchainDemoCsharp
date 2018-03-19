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
        private int BlockHash { get; set; }
        List<Transaction> Transactions { get; set; };
        
        
        public Block(int previousHash, List<Transaction> transactions)
        {
            PreviousHash = previousHash;
            Transactions = transactions;

            Object[] BlockData = new Object[2] { PreviousHash, Transactions.GetHashCode() };
            BlockHash = BlockData.GetHashCode();
        }

        public int GetPreviousHash()
        {
            return PreviousHash;
        }
        public int GetBlockHash()
        {
            return BlockHash;
        }
    }
}
