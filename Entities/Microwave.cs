using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
            Name = name;
            Description = description;
        }
        public override void Sound()
        {
            Console.WriteLine("Beep sound: Бип-бип...");
        }
    }
}
