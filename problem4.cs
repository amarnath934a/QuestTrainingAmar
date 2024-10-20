using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    class Calaculator : ICalculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;
    }
    internal class Program
    {
        static void Main()
        {
            ICalculator calculator = new Calaculator();
            int sum = calculator.Add(20, 50);
            Console.WriteLine("sum is: " + sum);

            int subtraction = calculator.Subtract(20, 50);
            Console.WriteLine("difference is: " + subtraction);

            Console.ReadLine();
        }
    }
}
