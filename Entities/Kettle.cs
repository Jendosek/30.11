using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
            Name = name;
            Description = description;
        }
        public override void Sound()
        {
            Console.WriteLine("Whistle sound: Шшшш...");
        }
    }
}
