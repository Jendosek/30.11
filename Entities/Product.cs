using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Product : Money
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public Product()
        {
            Name = "";
            Price = new Money();
        }
        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
