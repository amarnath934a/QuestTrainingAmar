using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    i--;
                }
            }

            RemoveOddNumbers(numbers);

            Console.WriteLine("\nList after removing odd numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void RemoveOddNumbers(List<int> numbers)
        {
            numbers.RemoveAll(number => number % 2 != 0);
        }
    }
}
