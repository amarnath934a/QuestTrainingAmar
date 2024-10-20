using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main()
    {
        Func<string, int> getLength = str =>
        {
            return str.Length;
        };
        Console.WriteLine(getLength("Hello"));
        Console.ReadLine();
    }

}
