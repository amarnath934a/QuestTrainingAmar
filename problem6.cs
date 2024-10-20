using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void PrintMessage(string message);

class Program
{
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        PrintMessage msg = DisplayMessage;
        msg("Hi friendssss");

        Console.ReadLine();
    }
}
