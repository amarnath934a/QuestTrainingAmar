using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace oops
{
    class Student
    {
       public string Name;
       public int Mark1;
       public int Mark2;
       public int Mark3;

       public void TotalMarks()
       {
           int total = Mark1 + Mark2 + Mark3;
           Console.WriteLine($"total marks: {total}");
           double average = total/ 3;
           Console.WriteLine($"average marks: {average}");
       }
    }
    internal class program
    {
       static void Main()
       {
          Student stud1 = new Student();
           stud1.Name = "Amar";
           stud1.Mark1 = 20;
           stud1.Mark2 = 30;
           stud1.Mark3 = 40;

           stud1.TotalMarks();
           Console.ReadLine();
       }

    }
    //class Smartphone
    //{
    //    public string Brand;
    //    public List<int> avilableVarient;


    //    public void Specifications()
    //    {
    //        Console.WriteLine($"mobile: {Brand}");
    //        Console.WriteLine($"Available Variants: {string.Join(", ", avilableVarient)}");
    //    }
    //}
    //internal class program
    //{
    //    static void Main()
    //    {
    //        Smartphone mobile = new Smartphone();
    //        mobile.Brand = "samsung";
    //        mobile.avilableVarient = new List<int>() { 64, 128, 256 };

    //        mobile.Specifications();
    //        Console.ReadLine();
    //    }

    //}
    //class Calculator
    //{
    //    public int Add(int num1, int num2)
    //    {
    //        return num1 + num2;
    //    }

    //    public int Subtract(int num1, int num2)
    //    {
    //        return num1 - num2;
    //    }

    //    public int Multiply(int num1, int num2)
    //    {
    //        return num1 * num2;
    //    }

    //    public double Divide(int num1, int num2)
    //    {
    //        return (double)num1 / num2;
    //    }

    //    public void DisplayResult(double result)
    //    {
    //        Console.WriteLine($"\nResult: {result}");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main()
    //    {
    //        Calculator calculator = new Calculator();

    //        Console.WriteLine("Enter first number: ");
    //        int num1 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Enter second number: ");
    //        int num2 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Choose operation (+, -, *, /): ");
    //        char operation = Console.ReadKey().KeyChar;

    //        double result = 0;
    //        Console.WriteLine();
    //        switch (operation)
    //        {
    //            case '+':
    //                result = calculator.Add(num1, num2);
    //                break;
    //            case '-':
    //                result = calculator.Subtract(num1, num2);
    //                break;
    //            case '*':
    //                result = calculator.Multiply(num1, num2);
    //                break;
    //            case '/':
    //                result = calculator.Divide(num1, num2);
    //                break;
    //            default:
    //                Console.WriteLine("Invalid");
    //                return;
    //        }

    //        calculator.DisplayResult(result);

    //        Console.ReadLine();
    //    }
    //}
    // class school
    // {
    //    public string StudentName;
    //    public int StudentId;
    //    public string grade;

    //    public school(int studentId, string studentName, string grade)
    //    {
    //        StudentId = studentId;
    //        StudentName = studentName;
    //        grade = grade;
    //    }
    //    public void ClassRoom()
    //    {
    //        Console.WriteLine($"\n student details: id: {StudentId} Name: {StudentName} class: {grade}");
    //    }
    // }
    // internal class Register
    // { 
    //    static void Main()
    //    {
    //        school student1 = new school(101,"amar","9th");
    //        school student2 =new school (102, "ravi", "9th");
    //        student1.ClassRoom();
    //        Console.ReadLine();

    //        var student3 = new school()
    //        {
    //            StudentId = 101,
    //            StudentName = "rahul",
    //            grade = "9th"
    //        };

    //    }
    // }

    //class Student
    //{
    //    public string Name;  
    //    public int[] Marks;   
    //    public Student(string name, int[] marks)
    //    {
    //        Name = name;
    //        Marks = marks;
    //    }

    //    public int GetTotalMarks()
    //    {
    //        int total = 0;
    //        foreach (int mark in Marks)
    //        {
    //            total += mark;
    //        }
    //        return total;
    //    }

    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine("Marks: " + string.Join(", ", Marks));
    //        Console.WriteLine($"Total Marks: {GetTotalMarks()}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Student[] students = new Student[5];

    //        students[0] = new Student("Amar", new int[] { 85, 90, 78 });
    //        students[1] = new Student("Ravi", new int[] { 90, 90, 90 });
    //        students[2] = new Student("Sita", new int[] { 88, 92, 86 });

    //        for (int i = 0; i < 5; i++)
    //        {
    //            if (students[i] != null)
    //            {
    //                students[i].DisplayDetails();
    //            }
    //        }
    //        Console.ReadLine();
    //    }
    //}
}