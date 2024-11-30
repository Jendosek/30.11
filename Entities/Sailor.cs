using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Sailor : Human
    {
        public string TypeOfShip { get; set; }

        public Sailor()
        {
            TypeOfShip = "No";
        }

        public Sailor(string name, int age, string typeOfShip) : base(name, age)
        {
            TypeOfShip = typeOfShip;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type of ship: {TypeOfShip}");
        }
    }
}
