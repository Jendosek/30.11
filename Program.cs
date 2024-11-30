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

            Tiger tiger = new Tiger("Animal", 10, "yellow");
            Crocodile crocodile = new Crocodile("Crocodile", 12, "Green");
            Kenguru kenguru = new Kenguru("Kenguru", 5, "Grey");

            tiger.Hunting();
            tiger.PrintInfo();
            crocodile.PrintInfo();
            kenguru.PrintInfo();
        }
    }
}
