using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 51, 1, 2, 3 };
        var evenNumbers = list.Where(n => n %2 == 0).ToList();
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        var sortDesc = list.OrderByDescending(n => n).ToList();
        Console.WriteLine("sorted in Descending order: " + string.Join(", ", sortDesc));

        var square = list.Select(n => n * n).ToList();
        Console.WriteLine("square: " + string.Join(", ", square));

        var squareEvenNumber = list.Select(n => n * n).Where(n => n % 2 == 0).ToList();
        Console.WriteLine("square of all even numbers: " +string.Join(", ", squareEvenNumber));

        var max = list.Max();
        Console.WriteLine("Max value: " + max);

        var min = list.Min();
        Console.WriteLine("Min value: " + min);

        var greaterThan50 = list.Any(n => n > 50);
        Console.WriteLine("greater than 50: " + string.Join (", ", greaterThan50));

        var allNumbersArePositive = list.All(n => n > 0);
        Console.WriteLine("positive numbers: " + allNumbersArePositive);

        var sumOfAllIntegers = list.Sum(n => n);
        Console.WriteLine("sum of all integers: " + sumOfAllIntegers);

        var removeDuplicate = list.Distinct().ToList();
        Console.WriteLine("removed : " + string.Join(", ", removeDuplicate)); 
        
        var gratertThan10 = list.Count(n => n > 0);
        Console.WriteLine("removed : " + string.Join(", ", greaterThan50));

        var skipFirstTake = list.Skip(5).Take(5).ToList();
        Console.WriteLine("skip first 5 and take next 5: " + string.Join(",", skipFirstTake));




        List<string> names = new List<string>() { "Amar","Bavi","ranjith","Bhanu"};
        var startsWithA = names.Where(s => s.StartsWith("A")).ToList();
        Console.WriteLine("starts with A: " + string.Join(", ", startsWithA));

        var startsWithB = names.FirstOrDefault(s => s.StartsWith("B"));
        Console.WriteLine("starts with b: " + string.Join(", ", startsWithB));

        var groupedWords = names.GroupBy(s => s.Length);
        foreach (var group in groupedWords)
        {
            Console.WriteLine($"Length {group.Key}: {string.Join(", ", group)}");
        }



        List<string> students = new List<string>() { "Amar", "Bavi", "ranjith", "Bhanu" };
        List<int> marks = new List<int>() { 20, 30, 40, 80 };

        var zip = students.Zip(marks, (student, mark) => new { student, mark });

        foreach (var pair in zip)
        {
            System.Console.WriteLine($"{pair.student}: {pair.mark}");
        }


        List<double> floatNumbers = new List<double> { 1.5, 2.5, 3.5 };
        var average = floatNumbers.Average();
        Console.WriteLine("Average: " + average.ToString());


        List<string> employees = new List<string> { "Amar", "ravi", "Ranjith" };
        List<int> departmentIds = new List<int> { 1, 2, 1 };
        List<string> departments = new List<string> { "HR", "Finance", "sales" };


        List<decimal> prices = new List<decimal> { 50.5m, 120.0m, 80.0m, 150.5m };
        var priceFilteredByPrice = prices.Where(x => x > 100).Select(x => x.ToString());
        Console.WriteLine(string.Join(", ", priceFilteredByPrice));
        Console.ReadKey();
    }
}
