using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace client
{
    public class Client
    {
        private readonly IPAddress _ipAddress;
        private readonly int _port;
        private TcpClient _client;
        private DateTime _date;

        public Client(string ipAddress, int port)
        {
            _ipAddress = IPAddress.Parse(ipAddress);
            _port = port;
            _client = new TcpClient();
            _date = DateTime.Now;
        }

        public void Connect()
        {
            _client.Connect(_ipAddress, _port);
            Console.WriteLine("Connected to server");
        }

        public void StartChat()
        {
            while (true)
            {
                Console.Write("Enter message: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);

                _client.GetStream().Write(data, 0, data.Length);

                byte[] response = new byte[1024];
                var dataLength = _client.GetStream().Read(response, 0, response.Length);
                var responseText = Encoding.UTF8.GetString(response, 0, dataLength);
                Console.WriteLine($"{_date} Server response: {responseText}");

                if (message == "quit")
                {
                    Disconnect();
                    break;
                }
            }
        }

        public void Disconnect()
        {
            _client.Close();
            Console.WriteLine("Disconnected from server");
        }
    }
}
