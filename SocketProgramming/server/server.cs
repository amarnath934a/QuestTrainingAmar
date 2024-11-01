using server;
using System;

namespace server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerBuilder()
                            .SetIPAddress("127.0.0.1")
                            .SetPort(8000)
                            .Build();

            server.Start();
        }
    }
}
