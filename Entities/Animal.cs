using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }    

        public Animal() 
        {
            Name = "Unknown";
            Age = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
