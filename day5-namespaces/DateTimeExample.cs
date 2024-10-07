using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_namespaces
{
    internal class DateTimeExample
    {
        public void ShowAge()
        {
            Console.Write("Enter your date of birth (dd-mm-yyyy): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime dateOfBirth))
            {
                if (dateOfBirth > DateTime.Now)
                {
                    Console.WriteLine("You are too early.");
                }
                else
                {
                    int age = CalculateAge(dateOfBirth);
                    Console.WriteLine("Your age is: " + age + " years");
                }
            }
            else
            {
                Console.WriteLine("Invalid enter in this format dd-mm-yyyy.");
            }
        }

        public int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
