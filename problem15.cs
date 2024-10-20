using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public virtual void MakeSound() => Console.WriteLine("Sounds");
}

class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Bark");
}
class program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound();

        Animal dog = new Dog();
        dog.MakeSound();

        Console.ReadLine();
    }
}

