using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

using System.IO;

namespace Node
{
    class RequestProcessor
    {
        static int PORT_NO = Configuration.FetchPort();
        static string SERVER_IP = Configuration.FetchServer();
        static string RequestReceived;

        public static void DataServer()
        {
            do
            {
                try
                {
                    if (!File.Exists(@Utility.LOCKPATH) && Utility.RecvLock)
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
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("1");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        /*
                         * Additional Decryption
                        */

                        Console.WriteLine("RECEVIED:" + RequestReceived);
                        Data.SaveBlock(RequestReceived, Configuration.SaltValue);
                        Utility.USER_REQUEST_PACKETS++;

                        client.Close();
                        listener.Stop();
                    }
                }
                catch (Exception ERROR)
                {
                    Console.WriteLine(ERROR.Message);
                }
            } while (true);
        }
    }
}