using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    abstract class Shape
    {
        public abstract double Area();
        public virtual void Show()
        {
            Console.WriteLine($"Area: {Area()}");
        }
    }
}
