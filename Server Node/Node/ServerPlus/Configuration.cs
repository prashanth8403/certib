using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Node
{
    class Configuration
    {
        private static int serverlock = 1;
        private static int portlock = 1;
        private static int Sycportlock = 1;
        public static string SaltValue { get; set; } = "1234";
        public static string ServerValue { get; set; }
        public static string NoOfNodes { get; set; } = "0";
        public static string AutoSync { get; set; }
        public static int PortValue { get; set; }
        public static int SyncPort { get; set; }
        public static string CONFIGPATH { get; set; } = "Configuration.config";

        public static int FetchPort()
        {
            try
            {
                if (portlock == 1)
                {
                    string _CONFIGURATION_DATA_ = File.ReadAllText(@CONFIGPATH);
                    JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
                    JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
                    PortValue = (int)items[0]["REVPORT"];
                    portlock = 0;
                }
            }
            catch (Exception ServerError)
            {
                portlock = 1;
                Console.WriteLine("Error:" + ServerError.Message);
            }
            return PortValue;
        }

        public static int FetchSycPort()
        {
            try
            {
                if (Sycportlock == 1)
                {
                    string _CONFIGURATION_DATA_ = File.ReadAllText(@CONFIGPATH);
                    JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
                    JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
                    SyncPort = (int)items[0]["SYCPORT"];
                    Sycportlock = 0;
                }
            }
            catch (Exception ServerError)
            {
                Sycportlock = 1;
                Console.WriteLine("Error:" + ServerError.Message);
            }
            return SyncPort;
        }

        public static string AutoStatus()
        {
            string _CONFIGURATION_DATA_ = File.ReadAllText(@CONFIGPATH);
            JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
            JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
            AutoSync = (string)items[0]["AUTOSYN"];
            return AutoSync;
        }

        public static void GetNodes()
        {
            string _CONFIGURATION_DATA_ = File.ReadAllText(@CONFIGPATH);
            JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
            JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
            ServerValue = (string)items[0]["SERVER"];
        }

        public static string FetchServer()
        {
            try
            {
                if (serverlock == 1)
                {
                    string _CONFIGURATION_DATA_ = File.ReadAllText(@CONFIGPATH);
                    JObject BLOCKCHAIN = JObject.Parse(_CONFIGURATION_DATA_);
                    JArray items = (JArray)BLOCKCHAIN["CONFIGURATION"];
                    ServerValue = (string)items[0]["SERVER"];
                    serverlock = 0;
                }
            }
            catch(Exception ServerError)
            {
                serverlock = 1;
                Console.WriteLine("Error:" + ServerError.Message);
            }
            return ServerValue;
        }
    }
}
