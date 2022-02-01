
namespace Lesson15.Modules
{
    public class Drinks : Product
    {
        public double Litters { get;  set; }
        public string Type { get;  set; }
        public Drinks()
        {
        }

        public override string ToString()
        {
            return $"{Barcode}, {Name}, {Type}, Litters-{Litters}l, price - {Price}Eu";
        }
    }
}
