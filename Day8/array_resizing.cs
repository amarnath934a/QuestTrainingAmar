using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class arrayResize
    {
        static void Main()
        {
            int[] Array = { 1, 2, 3, 4 };
            int newSize = 6;

            int[] resizeArray = new int[newSize];
            for (int i = 0; i < Array.Length; i++)
            {
                resizeArray[i] = Array[i];
            }

            Console.WriteLine("resized array:");
            foreach (int element in resizeArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
        
    }
}