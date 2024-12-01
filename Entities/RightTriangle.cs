using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class RightTriangle : Shape
    {
        public int FirstLine { get; set; }
        public int SecondLine { get; set; }
        public RightTriangle()
        {
            FirstLine = 0;
            SecondLine = 0;
        }
        public RightTriangle(int firstLine, int secondLine)
        {
            FirstLine = firstLine;
            SecondLine = secondLine;
        }
        public override double Area()
        {
            return 0.5 * FirstLine * SecondLine;
        }
        public override void Show()
        {
            Console.WriteLine($"Right Triangle: First Line = {FirstLine}, Second Line = {SecondLine}, Area = {Area()}");
        }
    }
}
