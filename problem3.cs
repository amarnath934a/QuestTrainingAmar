using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("cats says meeowwww");
    }

    class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("dog says bbbowwww");
    }
    internal class Program
    {
        static void Main()
        {
            IAnimal dog = new Dog();
            dog.Speak();

            IAnimal cat = new Cat();
            cat.Speak();

            Console.ReadLine();
        }
    }
}
