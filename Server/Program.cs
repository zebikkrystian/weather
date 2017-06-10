using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Db;

namespace Server
{
    /// <summary>
    /// Serwer
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StartListening();
        }

        /// <summary>
        /// Uchuchamia nasłuchiwanie
        /// </summary>
        public static void StartListening()
        {
            byte[] bytes = new Byte[1024];
            
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
            
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                
                while (true)
                {
                    Console.WriteLine("Oczekuje na połączenie");
                    Socket handler = listener.Accept();
                    
                    string data = null;
                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    data = data.Replace("<EOF>", "");
                    Console.WriteLine("Miasto : {0}", data);
                    
                    byte[] msg = Encoding.UTF8.GetBytes(Query.GetWeather(data));

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }
    }
}
