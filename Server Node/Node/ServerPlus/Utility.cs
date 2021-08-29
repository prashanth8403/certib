using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    class Utility
    {
        public static string DATAPATH { get; set; } = "Blocks/BLOCKS.CRYPTO";
        public static string LOCKPATH { get; set; } = "Blocks/Data.LOCK";
        public static int USER_REQUEST_PACKETS { get; set; } = 0;
        public static int facial { get; set; } = 0;
        public static int home { get; set; } = 0;
        public static int Juno_Function { get; set; } = 0;
        public static int Atlas_Function { get; set; } = 0;
        public static int No_Of_Nodes { get; set; } = 1;
        public static int DigLock { get; set; } = 1;
        public static int CPUVALUE { get; set; }
        public static int MEMVALUE { get; set; }
        public static bool RecvLock { get; set; } = true;

        public static void NodeUpdate()
        {
            No_Of_Nodes++;
        }

        public static int HomeLoad()
        {
            return home;
        }
        public static int Facial()
        {
            return facial;
        }
        public static int RequestsCount()
        {
            return USER_REQUEST_PACKETS;
        }
    }
}
