using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class ForeignPassport : Passport
    {
        public string Visa { get; set; }
        public string ExpiryDate { get; set; }

        public ForeignPassport()
        {
            Visa = "";
            ExpiryDate = "";
        }

        public ForeignPassport(string name, int age, Country nameOfCountry, string id, string visa, string expiryDate) : base(name, age, nameOfCountry, id)
        {
            Visa = visa;
            ExpiryDate = expiryDate;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Visa: {Visa}");
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
        }
    }
}
