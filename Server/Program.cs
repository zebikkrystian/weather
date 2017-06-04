using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Model;

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
            //Bufor na dane przychodzące
            byte[] bytes = new Byte[1024];

            //Pobieramy adres na którym działa aplikacja
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            //Endpoint na naszym adresie i porcie 11000
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            //Buduje socket 
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            
            try
            {
                //Podłączenie socketa do adresu
                listener.Bind(localEndPoint);
                //Przełączenie socket w tryb nasłuchiwania (liczba zapytań w kolejce)
                listener.Listen(10);
                
                while (true)
                {
                    Console.WriteLine("Oczekuje na połączenie");
                    //Uruchomienie socketa
                    Socket handler = listener.Accept();

                    //pobranie danych z żądania
                    string data = null;
                    while (true)
                    {
                        bytes = new byte[1024];
                        //pobiera dane do bufora po czym konwertuje na wyjściowy string aż do osiągnięcia komunikatu zakończenia - EOF
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    } 
                    //nazwa miasta
                    Console.WriteLine("Miasto : {0}", data);

                    //dane do odpowiedzi
                    byte[] msg = Encoding.UTF8.GetBytes(Helper.BuildData(data));

                    handler.Send(msg);
                    //zamknięcie soketa
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
