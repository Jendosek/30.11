using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Money
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }

        public Money() 
        {
            WholePart = 0;
            FractionalPart = 0;
        }

        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return $"{WholePart} грн. {FractionalPart} коп.";
        }
    }
}
