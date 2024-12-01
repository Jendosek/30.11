using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override void Show()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area()}");
        }
    }
}
