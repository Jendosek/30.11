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

            var devices = new Device[]
            {
                new Microwave("Microwave", "Microwave description"),
                new Kettle("Kettle", "Kettle description"),
                new Car("Car", "Car description"),
                new Steamship("Steamship", "Steamship description")
            };
            foreach (var device in devices)
            {
                device.Sound();
            }
        }
    }
}
