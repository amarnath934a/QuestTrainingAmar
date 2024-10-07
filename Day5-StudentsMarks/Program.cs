using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> studentMarks = new List<List<int>>();

            for (int i = 0; i < 5; i++)
            {
                List<int> marks = new List<int>();
                Console.WriteLine($"Enter marks for Student {i + 1}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Subject {j + 1}: ");
                    marks.Add(int.Parse(Console.ReadLine()));
                }
                studentMarks.Add(marks);
            }

            Console.WriteLine("\nMarks of all students:");
            for (int i = 0; i < studentMarks.Count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {string.Join(", ", studentMarks[i])}");
            }

            Console.ReadLine();
        }
    }
}
