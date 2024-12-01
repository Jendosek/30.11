using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Device()
        {
            Name = "Device";
            Description = "Description";
        }
        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void Sound()
        {
            Console.WriteLine("This device makes a sound.");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }
        public void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }
}