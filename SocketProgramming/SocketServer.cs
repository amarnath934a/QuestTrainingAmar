using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var date = DateTime.Now;

            var listener = new TcpListener(ip, port);
            listener.Start();
            Console.WriteLine($"App is Listening {ip} : {port}");

            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client Connected");
            
            bool isRunning = true;
            while(isRunning)
            { 
                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer, 0, dataLength);
                Console.WriteLine($"{date} Message Recived: {message}");

                if (message == "quit")
                {
                    Console.WriteLine(" Client Leaving the Chat");
                    isRunning = false;
                    break;
                }

                //Console.Write($"server:{message} ");
                //string response = Console.ReadLine();

                //if (response == "quit")
                //{
                //    Console.WriteLine(" server Leaving the Chat");
                //    isRunning = false;
                //    break;
                //}

                byte[] responseData = Encoding.UTF8.GetBytes(message);
                socket.Send(responseData);
            }

            socket.Close();
            listener.Stop();
        }
    }
}
