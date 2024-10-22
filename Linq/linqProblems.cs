using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int sumOfEvens = numbers.Skip(3).Where(n => n % 2 == 0).Sum();
//        Console.WriteLine("Sum of even numbers: " + sumOfEvens);

//        var firstFiveNumbers = numbers.Take(5);
//        Console.WriteLine("First 5 numbers: " + string.Join(", ", firstFiveNumbers));

//        var orderedNumbersAsc = numbers.OrderBy(n => n);
//        Console.WriteLine("Numbers in ascending order: " + string.Join(", ", orderedNumbersAsc));

//        var orderedNumbersDesc = numbers.OrderByDescending(n => n);
//        Console.WriteLine("Numbers in desscending order: " + string.Join(", ", orderedNumbersDesc));

//        var evenNumbers = numbers.Where(n => n % 2 == 0);
//        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

//        int max = numbers.Max();
//        Console.WriteLine("Max value: " + max);

//        int min = numbers.Min();
//        Console.WriteLine("Max value: " + min);

//        int sum = numbers.Sum();
//        Console.WriteLine("Max value: " + sum);

//        var firstItem = numbers.First();
//        Console.WriteLine("First item:" + firstItem);

//        var last = numbers.Last();
//        Console.WriteLine("Last item: " + last);

//        Console.ReadKey();
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        var data = new List<Person>()
//        {
//            new Person { Name = "Person1", Country = "US", Age = 20},
//            new Person { Name = "Person2", Country = "US", Age = 30 },
//            new Person { Name = "Person3", Country = "US", Age = 40 },
//            new Person { Name = "Person4", Country = "IN", Age = 50 },
//            new Person { Name = "Person5", Country = "IN", Age = 60 }
//        };

//        var distinctCountries = data.Select(person => person.Country).Distinct();

//        foreach (var country in distinctCountries)
//        {
//            Console.WriteLine(country);
//        }
//        Console.ReadLine();
//    }
//}

class Person
{
    public string Name { get; set; }
    public string Country { get; set; }
    
}
class Program
{
    static void Main(string[] args)
    {
        var data = new List<Person>()
        {
            new Person { Name = "Person 1", Country = "IN" },
            new Person { Name = "Person 10", Country = "IN" },
            new Person { Name = "Person 2", Country = "IN" },
            new Person { Name = "Person 3", Country = "US" },
            new Person { Name = "Person 4", Country = "CA" }
        };

        var groups = data.GroupBy(p => p.Country);
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key} = {group.Count()}");
            foreach (var person in group)
            {
                Console.WriteLine($"\t{person.Name}");
            }
        }
        Console.ReadKey();
    }
}



