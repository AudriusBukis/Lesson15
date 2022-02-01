
namespace Lesson15.Modules
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Barcode { get;  set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public Product(string name, int barcode, double weight, double price)
        {
            Name = name;
            Barcode = barcode;
            Weight = weight;
            Price = price;
        }

        protected Product(string name, int barcode, double price)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
        }
        protected Product()
        { }
    }
}
