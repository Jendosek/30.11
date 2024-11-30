using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    enum Country
    {
        USA,
        Ukraine,
        Canada,
        Germany,
        France,
        UK,
        Australia,
        China,
        Japan,
        India,
        None
    }

    internal class Passport
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Country NameOfCountry { get; set; }
        public string Id { get; set; }

        public Passport()
        {
            Name = "";
            Age = 0;
            NameOfCountry = Country.None;
            Id = "";
        }

        public Passport(string name, int age, Country nameOfCountry, string id)
        {
            Name = name;
            Age = age;
            NameOfCountry = nameOfCountry;
            Id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Name of Country: {NameOfCountry}");
            Console.WriteLine($"Id: {Id}");
        }
    }
}
