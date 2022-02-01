
namespace Lesson15.Modules
{
    public class Vegetables : Product
    {
        public string Fibers { get; set; }
        public Vegetables()
        {
        }
        public override string ToString()
        {
            return $"{Barcode}, {Name},fibers amount in 100g -{Fibers}, weight-{Weight}kg, price - {Price}Eu";
        }
    }
}
