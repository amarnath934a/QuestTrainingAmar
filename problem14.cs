using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Person
{
    public abstract void Work();
}

class Doctor : Person
{
    public override void Work() => Console.WriteLine("I,m a doctor");
}
class Engineer : Person
{
    public override void Work() => Console.WriteLine("I,m an engineer");
}

class program
{
    static void Main()
    {
        Person doctor = new Doctor();
        doctor.Work();

        Person engineer = new Engineer();
        engineer.Work();

        Console.ReadLine();
    }
}


