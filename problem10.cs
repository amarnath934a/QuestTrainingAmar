using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program 
{
    static void Main()
    {
        Action<int, int> printSum = Sum;
        int num1 = 10;
        int num2 = 20;
        printSum(num1, num2);
    }
    static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
        Console.ReadLine();
    }
}
