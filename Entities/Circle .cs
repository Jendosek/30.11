using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Show()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area()}");
        }
    }
}
