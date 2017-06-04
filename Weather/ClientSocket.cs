using Model;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Weather
{
    /// <summary>
    /// Klasa pomocnicza przy budowie socketu w kliencie
    /// </summary>
    public static class ClientSocket
    {
        /// <summary>
        /// Uruchamia socket klienta.
        /// </summary>
        /// <param name="city">Nazwa miasta</param>
        /// <returns>Dane o pogodzie</returns>
        public static WeatherModel StartClient(string city)
        {
            //bufor na dane
            byte[] bytes = new byte[1024];
            WeatherModel model = new WeatherModel();
            
            try
            {
                //adres servera z którego pobierzemy dane.
                IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                //Utworzenie soketu 
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
                try
                {
                    //Połączenie z soketem
                    sender.Connect(remoteEP);

                    Console.WriteLine("Połączono z {0}", sender.RemoteEndPoint.ToString());

                    //Utrzenie danych do wysłania (nazwy miasta)
                    byte[] msg = Encoding.UTF8.GetBytes(city + "<EOF>");

                    //wysłanie żądania
                    int bytesSent = sender.Send(msg);

                    //odebranie danych  
                    int bytesRec = sender.Receive(bytes);
                    //deseralizacja na model.
                    model = Helper.Deserialize<WeatherModel>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    //zamknięcie soketa
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return model;

        }
    }
}
