using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, string>();
            d.Add("First Name", "John");
            d.Add("Last Name", "Smith");
            Console.WriteLine(d["First Name"]);

            //Update
            d["First Name"] = "Jonny";
            Console.WriteLine(d["First Name"]);

            //Removal & Use var
            d.Remove("Last Name");
            Console.WriteLine("After Removal: ");
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");  
            }

            //if else
            if (d.ContainsKey("First Name")) 
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadLine();
        }
    }
}
