using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class Vegetables : Product
    {
        public string Fibers { get; set; }
        public Vegetables(string name, int barcode, double weight, double price, string fibers) : base(name, barcode, weight, price)
        {
            Fibers = fibers;
        }

        public Vegetables()
        {
        }

        public override string ToString()
        {
            return $"{Barcode}, {Name},fibers amount in 100g -{Fibers}, weight-{Weight}kg, price - {Price}Eu";
        }
    }
}
