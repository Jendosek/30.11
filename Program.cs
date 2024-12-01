using System.Text;
using ConsoleApp3.Entities;

namespace ConsoleApp3
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            var money = new Money(10, 50);
            var product = new Product("Product 1", money);
            Console.WriteLine(product);
        }
    }
}
