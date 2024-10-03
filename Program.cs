using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length : ");
            var length = int.Parse(Console.ReadLine());

            Console.Write("Enter width : ");
            var width = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == length - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
