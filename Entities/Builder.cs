using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Builder : Human
    {
        public string Specialization { get; set; }

        public Builder() : base()
        {
            Specialization = "No";
        }

        public Builder(string name, int age, string specialization) : base(name, age)
        {
            Specialization = specialization;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}
