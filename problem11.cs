using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Predicate<int> isEven = CheckEven;
        int number = 12058963;
        bool result = isEven(number);
        Console.WriteLine(result);
        Console.ReadLine();

    }
    static bool CheckEven(int number)
    {
        return number % 2 == 0;
    }
}
