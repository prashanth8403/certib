using System;
using System.IO;
using Silicon;
using System.Text;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;

namespace Node
{
    class Data
    {
        public static void SaveBlock(string DataStream, string _Salt)
        {
            try
            {
                string[] Data = DataStream.Split('$');
                string PrevAddress = "0";
                string __Block = "";
                if (Data[0] == "SYNCDATA")
                {
                    using (FileStream FILEHANDLE = File.Create(@Utility.DATAPATH))
                    {
                        string FileText = Data[1];
                        Byte[] ByteData = new UTF8Encoding(true).GetBytes(FileText);
                        FILEHANDLE.Write(ByteData, 0, ByteData.Length);
                        FILEHANDLE.Close();
                    }
                }
                else if (Data[0] == "SYNC")
                {
                    Utility.RecvLock = false;
                    string ___BLOCKDATA = File.ReadAllText(@Utility.DATAPATH);
                    string SERVER_IP = Data[1];
                    int PORT_NO = Convert.ToInt32(Data[2]);
                    TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                    NetworkStream nwStream = client.GetStream();
                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("SYNCDATA$" + ___BLOCKDATA);
                    nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[DATA SENT] >> " + SERVER_IP + ":" + PORT_NO.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                    client.Close();
                    Utility.RecvLock = true;
                }
                else
                {
                    if (File.Exists(@Utility.DATAPATH))
                    {
                        string ___BLOCKDATA = File.ReadAllText(@Utility.DATAPATH);
                        PrevAddress = GetPrevious(___BLOCKDATA);
                        __Block = GenerateBlock(Data[0], Data[1], PrevAddress, _Salt);
                        JObject BLOCKCHAIN = JObject.Parse(___BLOCKDATA);
                        JArray items = (JArray)BLOCKCHAIN["blocks"];
                        JObject NewBlock = JObject.Parse(__Block);
                        items.Add(NewBlock);
                        using (FileStream FILEHANDLE = File.Create(@Utility.DATAPATH))
                        {
                            string FileText = "{\"blocks\":\r\n" + items.ToString() + "\r\n}";
                            Byte[] ByteData = new UTF8Encoding(true).GetBytes(FileText);
                            FILEHANDLE.Write(ByteData, 0, ByteData.Length);
                            FILEHANDLE.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("CREATING NEW BLOCK (^_^)");

                        using (FileStream fs = File.Create(@Utility.DATAPATH))
                        {
                            Byte[] title = new UTF8Encoding(true).GetBytes("{\"blocks\":[]}");
                            fs.Write(title, 0, title.Length);
                        }

                        string ___BLOCKDATA = File.ReadAllText(@Utility.DATAPATH);
                        __Block = GenerateBlock(Data[0], Data[1], PrevAddress, _Salt);
                        JObject BLOCKCHAIN = JObject.Parse(___BLOCKDATA);
                        JArray items = (JArray)BLOCKCHAIN["blocks"];
                        JObject NewBlock = JObject.Parse(__Block);
                        items.Add(NewBlock);
                        using (FileStream FILEHANDLE = File.Create(@Utility.DATAPATH))
                        {
                            string FileText = "{\"blocks\":\r\n" + items.ToString() + "\r\n}";
                            Byte[] ByteData = new UTF8Encoding(true).GetBytes(FileText);
                            FILEHANDLE.Write(ByteData, 0, ByteData.Length);
                            FILEHANDLE.Close();
                        }
                    }
                }
            }
            catch (Exception FILEEX)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: " + FILEEX.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static string GetPrevious(string BlockData)
        {
            JObject data = JObject.Parse(BlockData);
            JArray items = (JArray)data["blocks"];
            int length = items.Count;
            string ADDRESS = (string)items[length - 1]["blockhash"];
            return ADDRESS;
        }

        public static string GenerateBlock(string CERTIFICATEDATA, string TIMESTAMP, string ADDRESS, string SALT)
        {
            string NEWBLOCK = "{\r\n";
            JObject NewBlock = JObject.Parse(CERTIFICATEDATA);
            NEWBLOCK += "\t\"previoushash\":\"" + ADDRESS + "\",\r\n";
            NEWBLOCK += "\t\"certificate\": " + CERTIFICATEDATA + ",\r\n";
            NEWBLOCK += "\t\"timestamp\":\"" + TIMESTAMP + "\",\r\n";
            NEWBLOCK += "\t\"blockhash\":\"" + SILICON64.GenerateHash(Convert.ToString(NewBlock) + TIMESTAMP + ADDRESS + SALT) + "\"\r\n";
            NEWBLOCK += "}";
            return NEWBLOCK;
        }
    }
}