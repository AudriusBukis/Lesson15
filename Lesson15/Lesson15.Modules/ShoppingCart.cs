using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class ShoppingCart : Product
    {
        public string Amount { get; set; }
        public ShoppingCart(string name, int barcode, string amount, double price) : base(name, barcode, price)
        {
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{Barcode}, {Name}, {Amount}, price - {Price}Eu";
        }
    }
}
