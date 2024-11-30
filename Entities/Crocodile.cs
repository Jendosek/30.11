using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Crocodile : Animal
    {
        public string Color { get; set; }

        public Crocodile() : base()
        {
            Color = "Unknown";
        }

        public Crocodile(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {Color}");

        }
}
