using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace server
{
    public class Server
    {
        private readonly IPAddress _ipAddress;
        private readonly int _port;
        private TcpListener _listener;

        public Server(IPAddress ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
            _listener = new TcpListener(_ipAddress, _port);
        }

        public void Start()
        {
            _listener.Start();
            Console.WriteLine($"Server is listening on {_ipAddress} : {_port}");
            var socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected");

            bool isRunning = true;
            while (isRunning)
            {
                byte[] buffer = new byte[1024];
                int dataLength = socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer, 0, dataLength);
                Console.WriteLine($"Message received: {message}");

                if (message == "quit")
                {
                    Console.WriteLine("Client disconnected");
                    isRunning = false;
                    break;
                }

                Console.Write("Server: ");
                string response = Console.ReadLine();

                if (response == "quit")
                {
                    Console.WriteLine("Server shutting down");
                    isRunning = false;
                    break;
                }

                byte[] responseData = Encoding.UTF8.GetBytes(response);
                socket.Send(responseData);
            }

            socket.Close();
            _listener.Stop();
            Console.WriteLine("Server stopped");
        }
    }

    public class ServerBuilder
    {
        private IPAddress _ipAddress = IPAddress.Loopback;
        private int _port = 8000;

        public ServerBuilder SetIPAddress(string ipAddress)
        {
            _ipAddress = IPAddress.Parse(ipAddress);
            return this;
        }

        public ServerBuilder SetPort(int port)
        {
            _port = port;
            return this;
        }

        public Server Build()
        {
            return new Server(_ipAddress, _port);
        }
    }
}
