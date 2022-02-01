
namespace Lesson15.Modules
{
    public class Meat : Product
    {
        public string Proteins { get;  set; }
       
        public Meat()
        {
        }

        public override string ToString()
        {
            return $"{Barcode}, {Name},proteins amount in 100g -{Proteins}, weight-{Weight}kg, price - {Price}Eu";
        }
    }
}
