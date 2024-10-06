using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestDay2
{
    internal class Program
    {

        //static string[] ConvertNamesToUpper(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToUpper(); 
        //    }
        //    return names;
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter no.of names : ");
        //    int count = int.Parse(Console.ReadLine());

        //    string[] names = new string[count];

        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write($"Enter name {i + 1}:");
        //        names[i] = Console.ReadLine();
        //    }

        //    string[] upperCaseNames = ConvertNamesToUpper(names);

        //    Console.Write("\nNames in uppercase:");
        //    foreach (string name in upperCaseNames)
        //    {
        //        Console.WriteLine(name);
        //        Console.ReadLine();
        //    }


        //}


        //static void FindNamesContainingChar(string[] names, char searchChar)
        //{
        //    Console.WriteLine($"\nNames containing the character '{searchChar}':");
        //    bool found = false;

        //    foreach (string name in names)
        //    {

        //        if (name.IndexOf(searchChar, (char)StringComparison.OrdinalIgnoreCase) >= 0)
        //        {
        //            Console.WriteLine(name);
        //            found = true;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine("No names found");
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    string[] names = { "Amar", "Ravi", "Ranjith", "tharun" };

        //    Console.WriteLine("Available names:");
        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name);
        //    }

        //    Console.WriteLine("\nEnter a character to search:");
        //    char searchChar = Console.ReadKey().KeyChar; // Read a single character
        //    Console.WriteLine(); // Move to the next line

        //    FindNamesContainingChar(names, searchChar);

        //    Console.ReadKey();
        //}


        //static string[] TrimAndReplace(string[] names, string oldWord, string newWord)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].Trim();
        //        names[i] = names[i].Replace(oldWord, newWord);
        //    }
        //    return names;
        //}
        //static void Main(string[] args)
        //{
        //    string[] names = { "  ravi  ", " amar ", "  ranjith  ", " tharun ", "  imran " };

        //    Console.WriteLine("Initial names:");
        //    foreach (string name in names)
        //    {
        //        Console.WriteLine($"'{name}'");
        //    }

        //    string oldWord = "ravi";
        //    string newWord = "Rahul"; 

        //    string[] modifiedNames = TrimAndReplace(names, oldWord, newWord);

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Enter a sentence:");
        //    string input = Console.ReadLine();

        //    string[] words = input.Split(' ');

        //    string[] Words = new string[words.Length];
        //    int[] counts = new int[words.Length];
        //    int Count = 0;

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string currentWord = words[i];
        //        bool found = false;

        //        for (int j = 0; j < Count; j++)
        //        {
        //            if (Words[j] == currentWord)
        //            {
        //                counts[j]++;
        //                found = true;
        //                break;
        //            }
        //        }

        //        if (!found)
        //        {
        //            Words[Count] = currentWord;
        //            counts[Count] = 1;
        //            Count++;
        //        }
        //    }

        //    Console.WriteLine("\nNo.of times spotted:");
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine($"{Words[i]}: {counts[i]} times");
        //    }

        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{

        //    Console.Write("Enter a string:");
        //    string input = Console.ReadLine();

        //    if (IsPalindrome(input))
        //    {
        //        Console.WriteLine($"{input} is a palindrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{input} is not a palindrome.");
        //    }

        //    Console.ReadKey();
        //}

        //static bool IsPalindrome(string str)
        //{

        //    char[] charArray = str.ToCharArray();
        //    Array.Reverse(charArray);
        //    string reversedStr = new string(charArray);

        //    return str == reversedStr;
        //}



        //static void Main(string[] args)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    int[] numbers = { 0, 1, 2, 3, 4 };

        //    foreach (int num in numbers)
        //    {
        //        sb.Append("Number " + num + " ");
        //    }

        //    Console.WriteLine(sb.ToString());
        //    Console.ReadLine();

        //}



        //static void Main(string[] args)
        //{

        //    int[] numbers = { 1, 2, 3, 4, 5, 6 };

        //    var firstHalf = numbers.Take(numbers.Length / 2).Reverse().ToArray();
        //    var secondHalf = numbers.Skip(numbers.Length / 2).Reverse().ToArray();
        //    firstHalf.CopyTo(numbers, 0);
        //    secondHalf.CopyTo(numbers, numbers.Length / 2);
        //    Console.WriteLine(string.Join(", ", numbers)); 
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    string[] number = { "one", "2", "three", "4" };

        //    string[] modifiedWords = new string[number.Length];
        //    int index = 0;

        //    foreach (string word in number)
        //    {
        //        if (word == "1")
        //            modifiedWords[index] = "one";
        //        else if (word == "2")
        //            modifiedWords[index] = "two";
        //        else if (word == "3")
        //            modifiedWords[index] = "three";
        //        else if (word == "4")
        //            modifiedWords[index] = "four";
        //        else
        //            modifiedWords[index] = "zero";
        //        index++;
        //    }
        //    Console.WriteLine(string.Join(", ", modifiedWords));
        //    Console.ReadLine(); 
        //}



        //static void Main(string[] args)
        //{
        //    Console.Write("Enter message : ");
        //    string input = Console.ReadLine();
        //    string result = "";

        //    foreach (char c in input)
        //    {
        //        if (char.IsUpper(c))
        //        {
        //            result += char.ToLower(c);
        //        }
        //        else if (char.IsLower(c))
        //        {
        //            result += char.ToUpper(c);
        //        }
        //        else
        //        {
        //            result += c;
        //        }
        //    }
        //    Console.WriteLine("Initial: " + input);
        //    Console.WriteLine("Converted: " + result);
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    Console.Write("Enter number of lines : ");
        //    int rows = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= rows; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    Console.Write("Enter number of lines : ");
        //    int rows = int.Parse(Console.ReadLine());
        //    int num = 1;
        //    for (int i = 1; i <= rows; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write(num + " ");
        //            num++;
        //        }
        //        Console.WriteLine();

        //    }
        //    Console.ReadLine();
        //}


        // static void Main(string[] args)
        // {
        //     Console.Write("Enter number of lines : ");
        //     int rows = int.Parse(Console.ReadLine());
        //     int num = 1;

        //     for (int i = 1; i <= rows; i++)
        //     {
        //         for (int j = 1; j <= i; j++)
        //         {
        //             Console.Write(j + " ");
        //             num++;
        //         }
        //         Console.WriteLine();

        //     }
        //     Console.ReadLine();
        // }


 static void Main()
 {
     Console.WriteLine("enter value");
     string input = Console.ReadLine();
     string vowels = "aeiouAEIOU";
     foreach (char ch in input)
     {
         if (vowels.Contains(ch))
         {
             Console.WriteLine("vowels are : " + ch);
         }
     }
     Console.ReadLine();
 }
    }
}

