using ConsoleApp3.Entities;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void  Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            ForeignPassport passport = new ForeignPassport("John Doe", 25, Country.Ukraine, "AA123456", "Mastercard", "1243124");
        }
    }
}
