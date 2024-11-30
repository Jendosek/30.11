using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Pilot : Human
    {
        public string TypeOfPlane { get; set; }
        public Pilot() : base()
        {
            TypeOfPlane = "No";
        }

        public Pilot(string name, int age, string typeOfPlane) : base(name, age)
        {
            TypeOfPlane = typeOfPlane;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type of plane: {TypeOfPlane}");
        }
    }
}
