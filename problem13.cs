using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Appliances
{
    public abstract void TurnOn();
}
class Fan : Appliances
{
    public override void TurnOn()
    {
        Console.WriteLine("fan is ON");
        Console.ReadLine();
    }
}

class program 
{
    static void Main()
    {
        Appliances fan = new Fan();
        fan.TurnOn();
        Console.ReadLine() ;
    }
}
