using System;

class Employee
{
    public double Salary { get; set; }

    public Employee(double salary) => Salary = salary;

    public virtual double CalculateBonus() => Salary * 0.50;
}

class Manager : Employee
{
    public Manager(double salary) : base(salary) { }

    public override double CalculateBonus() => Salary * 0.50;
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee(30000);
        Console.WriteLine("Employee hike: " + employee.CalculateBonus());

        Manager manager = new Manager(40000);
        Console.WriteLine("Manager hike: " + manager.CalculateBonus());

        Console.ReadLine();
    }
}
