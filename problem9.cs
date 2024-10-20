using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        Action<string> printMessage = DisplayMessage;
        printMessage("Welcome");
        Console.ReadLine();
    }
}
