using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    delegate int Operation(int a, int b);

    class Calaculation
    {
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;
    }
    class Program
    {
        static void Main()
        {
            Operation operation = Calaculation.Add;
            int result = operation(20, 10);
            Console.WriteLine("result of sum: " + result);

            operation = Calaculation.Multiply;
            result = operation(20, 10);
            Console.WriteLine("result of multiply: " + result);
            Console.ReadLine();
        }
    }
}
