using client;
using System;

namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("127.0.0.1", 8000);

            client.Connect();
            client.StartChat();
        }
    }
}
