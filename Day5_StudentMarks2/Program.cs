using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> studentMarks = new List<List<int>>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the number of subjects for student {i + 1}: ");
                int subjectCount = int.Parse(Console.ReadLine());
                List<int> marks = new List<int>();

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"Enter mark for Subject {j + 1}: ");
                    marks.Add(int.Parse(Console.ReadLine()));
                }
                studentMarks.Add(marks);
            }

            Console.WriteLine("\nMarks of all students:");
            foreach (var marks in studentMarks)
            {
                Console.WriteLine(string.Join(", ", marks));
            }
            Console.ReadLine();
        }
    }
}
