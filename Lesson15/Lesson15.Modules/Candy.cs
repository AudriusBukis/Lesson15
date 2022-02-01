
namespace Lesson15.Modules
{
    public class Candy : Product
    {
        public string SugarAmount { get; set; }
        public Candy()
        { }

        public override string ToString()
        {
            return $"{Barcode}, {Name},sugar amount in 100g -{SugarAmount}, weight-{Weight}kg, price - {Price}Eu";
        }
    }
}
