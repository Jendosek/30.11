using ConsoleApp3.Entities;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Shape rectangle = new Rectangle(5, 10);
            Shape circle = new Circle(5);
            Shape rightTriangle = new RightTriangle(5, 10);
            Shape trapezoid = new Trapezoid(5, 10, 15);
            Shape[] shapes = { rectangle, circle, rightTriangle, trapezoid };

            foreach (var shape in shapes)
            {
                shape.Show();
                Console.WriteLine();
            }

        }
    }
}
