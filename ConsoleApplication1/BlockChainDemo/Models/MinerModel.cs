using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainDemo.Models
{
    class MinerModel
    {
        public int ID { get; set; }
        public List<string> BlockHashes { get; set; }

        public MinerModel(int id, List<string> blockHashes)
        {
            ID = id;
            BlockHashes = blockHashes;
        }
    }
}
