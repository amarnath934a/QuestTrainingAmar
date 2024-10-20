using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        Func<int, int, int> mul = Multiply;
        Console.WriteLine(mul(763, 367));   
    }
}
