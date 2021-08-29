using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;

namespace Node
{
    class Server
    {
        static string RequestReceived;
        public static void SyncRequest(string SERVER_IP, int PORT_NO)
        {
            string Data = "SYNC$" + Configuration.FetchServer() + "$" + Configuration.FetchPort().ToString();
            SendData(SERVER_IP, Data, PORT_NO);
            //FetchData(Configuration.FetchServer(), Configuration.FetchSycPort());
        }

        public static void SendData(string SERVER_IP, string Data, int PORT_NO)
        {
            try
            {
                TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Data);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[" + SERVER_IP + ":" + PORT_NO.ToString() + "]" + "-- Sync Request Sent");
                Console.ForegroundColor = ConsoleColor.White;
                client.Close();
            }
            catch (Exception Ex)
            {
                if (Ex.Message != "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + Ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public static void FetchData(string SERVER_IP, int PORT_NO)
        {
            try
            {
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                Console.WriteLine("Server Running:[" + SERVER_IP + ":" + PORT_NO + "] >>>");
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                RequestReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                /*
                 * Additional Decryption
                */

                Console.WriteLine("RECEVIED:" + RequestReceived);

                using (FileStream FILEHANDLE = File.Create(@Utility.DATAPATH))
                {
                    string FileText = RequestReceived;
                    Byte[] ByteData = new UTF8Encoding(true).GetBytes(FileText);
                    FILEHANDLE.Write(ByteData, 0, ByteData.Length);
                    FILEHANDLE.Close();
                }

                client.Close();
                listener.Stop();
            }
            catch (Exception ERROR)
            {
                Console.WriteLine(ERROR.Message);
            }
        }
    }

}
