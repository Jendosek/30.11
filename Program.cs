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

            Builder builder = new Builder("Zenya", 18, "Stroyka");
            Sailor sailor = new Sailor("Vova", 17, "dayn");
            Pilot pilot = new Pilot("Dima", 15, "Galandskiy shturval");

            builder.PrintInfo();
            sailor.PrintInfo();
            pilot.PrintInfo();
        }
    }
}
