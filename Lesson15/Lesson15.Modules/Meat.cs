using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class Meat : Product
    {
        public string Proteins { get;  set; }
        public Meat(string name, int barcode, double weight, double price, string proteins) : base(name, barcode, weight, price)
        {
            Proteins = proteins;
        }

        public Meat()
        {
        }

        public override string ToString()
        {
            return $"{Barcode}, {Name},proteins amount in 100g -{Proteins}, weight-{Weight}kg, price - {Price}Eu";
        }
    }
}
