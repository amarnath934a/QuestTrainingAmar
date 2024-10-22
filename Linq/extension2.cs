using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnCSharp;

class Program
{
    static void Main()
    {
        int num1 = 2;
        int num2 = 3;

        Console.WriteLine($"{num1} is even: {num1.IsEven()}");
        Console.WriteLine($"{num2} is odd: {num2.IsOdd()}");
        Console.ReadKey();
    }
}
