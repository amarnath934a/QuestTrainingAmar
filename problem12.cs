using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main()
    {
        Predicate<string> letterA = CheckStartWithA;
        string word = "Amar";
        bool result = letterA(word);
        Console.WriteLine(result);
        Console.ReadLine();
    }
    static bool CheckStartWithA(string word)
    {
        return word.StartsWith("A", StringComparison.OrdinalIgnoreCase);
    }
}
