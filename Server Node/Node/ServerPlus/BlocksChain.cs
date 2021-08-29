using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Silicon;
using System.Threading.Tasks;

namespace Node
{
    class BlocksChain
    {
        public static bool Validation(string PreviousAddress, string NextAddress)
        {
            if (PreviousAddress == NextAddress)
                return true;
            else
                return false;
        }

        public static bool BlockValidation(string CurrentHash, string Blockhash)
        {
            if (CurrentHash == Blockhash)
                return false;
            else
                return true;
        }

        public static string GenerateBlockHash(string votehash, string timestamp,string Address, string Salt)
        {
            return SILICON64.GenerateHash(votehash + timestamp + Address + Salt);
        }
    }
}
