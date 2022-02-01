using System;
using System.Collections.Generic;

namespace Lesson15.Modules
{
    public class ShoppingCartRepository
    {
        
        public List<ShoppingCart> ShoppCart { get; set; }

        public ShoppingCartRepository()
        {
            ShoppCart = new List<ShoppingCart>();
        }
        public void PrintAllList()
        {
            foreach (var product in ShoppCart)
            {
                Console.WriteLine($"No.{ShoppCart.IndexOf(product)+1} - {product}");
            }
        }
        public void AddToCart(Vegetables product)
        {
            string name = product.Name;
            int barcode = product.Barcode;
            string amount = $"{product.Weight} kg";
            double price = product.Price;
            var productItem = new ShoppingCart(name, barcode, amount, price);
            ShoppCart.Add(productItem);
        }
        public void AddToCart(Meat product)
        {
            string name = product.Name;
            int barcode = product.Barcode;
            string amount = $"{product.Weight} kg";
            double price = product.Price;
            var productItem = new ShoppingCart(name, barcode, amount, price);
            ShoppCart.Add(productItem);
        }
        public void AddToCart(Candy product)
        {
            string name = product.Name;
            int barcode = product.Barcode;
            string amount = $"{product.Weight * 1000} g";
            double price = product.Price;
            var productItem = new ShoppingCart(name, barcode, amount, price);
            ShoppCart.Add(productItem);
        }
        public void AddToCart(Drinks product)
        {
            string name = product.Name;
            int barcode = product.Barcode;
            string amount = $"{product.Litters} l";
            double price = product.Price;
            var productItem = new ShoppingCart(name, barcode, amount, price);
            ShoppCart.Add(productItem);
        }

        public static double GenerateCheck(List<ShoppingCart> cartItem)
        {
            var cartToFile = new FileWriterService("CartCheck.txt");
            var templist = new List<string>();
            double totalPrice = 0;
            cartToFile.WriteAllText(templist.ToArray());
            cartToFile.AppendText($"date {DateTime.Today}");
            cartToFile.AppendText("----------------------------");
            foreach (ShoppingCart product in cartItem)  
            {
                cartToFile.AppendText($"{product.Barcode},{product.Name},{product.Amount} - {product.Price} eu");
                totalPrice += product.Price;
            }
            cartToFile.AppendText("----------------------------");
            cartToFile.AppendText($"Total price to pay - {Math.Round(totalPrice, 2)} eu");
            return totalPrice;
        }
    }
}
