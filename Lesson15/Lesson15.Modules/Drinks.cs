using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class Drinks : Product
    {
        public double Litters { get;  set; }
        public string Type { get;  set; }
        public Drinks(string name, int barcode, double litters, double price, string type) : base(name, barcode, price)
        {
            Litters = litters;
            Type = type;
        }

        public Drinks()
        {
        }

        public override string ToString()
        {
            return $"{Barcode}, {Name}, {Type}, Litters-{Litters}l, price - {Price}Eu";
        }
    }
}
