using System;
using System.Numerics;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit militaryUnit = 
                new MilitaryUnit(5,5,5,5);

            SettlerUnit settlerUnit = new SettlerUnit(2,10);
            
            militaryUnit.Move(new Vector2(5,5));
            settlerUnit.Move(new Vector2(2,2));
            Console.WriteLine($"Military: Health:{militaryUnit.Health} Value:{militaryUnit.Value}");
            Console.WriteLine($"Settler : Health:{settlerUnit.Health} Value:{settlerUnit.Value}");

            Console.WriteLine(militaryUnit.ToString());
        }
    }
}
