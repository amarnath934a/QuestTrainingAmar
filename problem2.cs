using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Drive();
    }

    class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine($"car speed is {Speed} km/hr");
    }

    class Bicycle : Vehicle
    {
        public override void Drive() => Console.WriteLine($"Bicycle speed is {Speed} km/hr");

    }

    class Program
    {
        static void Main()
        {
            Vehicle car = new Car();
            car.Speed = 80;
            car.Drive();

            Vehicle bicycle = new Bicycle();
            bicycle.Speed = 10;
            bicycle.Drive();

            Console.ReadLine();

        }
    }
}
