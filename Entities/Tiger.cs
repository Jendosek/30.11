using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Tiger : Animal
    {
        public string Color { get; set; }

        public Tiger() : base()
        {
            Color = "Unknown";
        }

        public Tiger(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public void Hunting()
        {
            Console.WriteLine("Tiger is hunting");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {Color}");
        }
    }
}
