using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Trapezoid  : Shape
    {
        public int Base1 { get; set; }
        public int Base2 { get; set; }
        public int Height { get; set; }
        public Trapezoid()
        {
            Base1 = 0;
            Base2 = 0;
            Height = 0;
        }
        public Trapezoid(int base1, int base2, int height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }
        public override double Area()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }
        public override void Show()
        {
            Console.WriteLine($"Trapezoid: Base1 = {Base1}, Base2 = {Base2}, Height = {Height}, Area = {Area()}");
        }
    }
}
