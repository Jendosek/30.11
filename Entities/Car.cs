using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
            Name = name;
            Description = description;
        }
        public override void Sound()
        {
            Console.WriteLine("Car sound: Врум-врум...");
        }
    }
}
