using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class StoreRepository
    {
        public (bool HeveMoney, double WalletSize) WelcomToStore()
        {
            
                Console.Clear();
                Console.WriteLine("Welcome to store");
                Console.WriteLine("Enter how much money do you have ? ");
                if (Double.TryParse(Console.ReadLine(), out double result))
                {
                    return ( true, result);
                }
                else
                {
                    Console.WriteLine("You entered not a number, press enter to continue");
                    Console.ReadKey();
                    return (false, 0);
                }
        }
        public void ReturnToStore()
        {
            Console.WriteLine("Press enter to return to store");
            Console.ReadKey();
        }
        public void PressEnterContinue()
        {
            Console.WriteLine("press enter to continue");
            Console.ReadKey();
        }
        public void AddingProductsToCart(MeatRepository meats, ShoppingCartRepository cart)
        {
            bool buyMeat = true;
            while (buyMeat)
            {
                Console.Clear();
                meats.PrintAllList();
                Console.WriteLine("if you want exit the list perss y ");
                string inputString = Console.ReadLine().ToLower().Trim();
                if (inputString == "y")
                {
                    break;
                }
                else if (Int32.TryParse(inputString, out int indexNumber))
                {
                    if (indexNumber >= 0 && indexNumber < meats.MeatList.Count)
                    {
                        cart.AddToCart(meats.MeatList[indexNumber]);
                        Console.WriteLine("Product added to cart");
                        PressEnterContinue();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No such product");
                        PressEnterContinue();
                        continue;
                    }
                }
                else
                {
                    PressEnterContinue();
                    continue;
                }
            }
            
        }
        public void AddingProductsToCart(CandyRepository candys, ShoppingCartRepository cart)
        {
            bool buyCandy = true;
            while (buyCandy)
            {
                Console.Clear();
                candys.PrintAllList();
                Console.WriteLine("if you want exit the list perss y ");
                string inputString = Console.ReadLine().ToLower().Trim();
                if (inputString == "y")
                {
                    break;
                }
                else if (Int32.TryParse(inputString, out int indexNumber))
                {
                    if (indexNumber >= 0 && indexNumber < candys.CandyList.Count)
                    {
                        cart.AddToCart(candys.CandyList[indexNumber]);
                        Console.WriteLine("Product added to cart");
                        PressEnterContinue();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No such product");
                        PressEnterContinue();
                        continue;
                    }
                }
                else
                {
                    PressEnterContinue();
                    continue;
                }
            }
        }
        public void AddingProductsToCart(DrinksRepository drinks, ShoppingCartRepository cart)
        {
            bool buyDrink = true;
            while (buyDrink)
            {
                Console.Clear();
                drinks.PrintAllList();
                Console.WriteLine("if you want exit the list perss y ");
                string inputString = Console.ReadLine().ToLower().Trim();
                if (inputString == "y")
                {
                    break;
                }
                else if (Int32.TryParse(inputString, out int indexNumber))
                {
                    if (indexNumber >= 0 && indexNumber < drinks.DrinksList.Count)
                    {
                        cart.AddToCart(drinks.DrinksList[indexNumber]);
                        Console.WriteLine("Product added to cart");
                        PressEnterContinue();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No such product");
                        PressEnterContinue();
                        continue;
                    }
                }
                else
                {
                    PressEnterContinue();
                    continue;
                }
            }
        }
        public void AddingProductsToCart(VegetablesRepository vegetables, ShoppingCartRepository cart)
        {
            bool buyVegetables = true;
            while (buyVegetables)
            {
                Console.Clear();
                vegetables.PrintAllList();
                Console.WriteLine("if you want exit the list perss y ");
                string inputString = Console.ReadLine().ToLower().Trim();
                if (inputString == "y")
                {
                    break;
                }
                else if (Int32.TryParse(inputString, out int indexNumber))
                {
                    if (indexNumber >= 0 && indexNumber < vegetables.VegetablesList.Count)
                    {
                        cart.AddToCart(vegetables.VegetablesList[indexNumber]);
                        Console.WriteLine("Product added to cart");
                        PressEnterContinue();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No such product");
                        PressEnterContinue();
                        continue;
                    }
                }
                else
                {
                    PressEnterContinue();
                    continue;
                }
            }
        }
    }
}
