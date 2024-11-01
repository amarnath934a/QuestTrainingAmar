using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var date = DateTime.Now;

            var client = new TcpClient();
            client.Connect(ip, port);
            Console.WriteLine("Connected to server");

            while (true)
            { 
                Console.Write($"Enter message: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);

                client.GetStream().Write(data, 0, data.Length);

                byte[] response = new byte[1024];
                var dataLength = client.GetStream().Read(response, 0, response.Length);
                var responseText = Encoding.UTF8.GetString(response,0, dataLength);
                Console.WriteLine($"{date} Server response: {responseText}");
            }
            
        }
    }
}
