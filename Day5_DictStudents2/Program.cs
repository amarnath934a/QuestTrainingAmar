using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictStudents2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();
            while (true)
            {
                Console.Write("Enter an ID or q to exit: ");
                var option = Console.ReadLine();

                if (option == "q")
                {
                    break;
                }

                if (d.ContainsKey(option))
                {
                    Console.Write("ID already exists.Replace it? (y/n): ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        continue; // Skip to next if choice is no
                    }
                }

                var marks = new List<int>();
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"Enter mark {i}: ");
                    marks.Add(int.Parse(Console.ReadLine()));
                }
                d[option] = marks; // replace existing entry
            }

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
