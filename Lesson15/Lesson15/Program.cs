using Lesson15.Modules;
using System;

namespace Lesson15
{
    internal class Program
    {
        static double WalletSize;
        static bool HaveMoney;
        private static readonly ShoppingCartRepository Cart = new();

        static void Main(string[] args)
        {
            var store = new StoreRepository();

            var candys = new CandyRepository();
            var meats = new MeatRepository();
            var drinks = new DrinksRepository();
            var vegetables = new VegetablesRepository();
            bool isTrue = true;
            while (isTrue)
            {
                Cart.ShoppCart.Clear();
                (HaveMoney, WalletSize) = store.WelcomToStore();
                if (HaveMoney == true && WalletSize < 0)
                {
                    while(HaveMoney)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to store");
                        Console.WriteLine("Because you dont have money you can only view product list");
                        Console.WriteLine(" 1 - Candy products;");
                        Console.WriteLine(" 2 - Meat products");
                        Console.WriteLine(" 3 - Drinks products");
                        Console.WriteLine(" 4 - Vegetable products");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(" 5 - Exit store");               
                        if (Int32.TryParse(Console.ReadLine(), out int inputNumber))
                        {
                            switch (inputNumber)
                            {
                                case 1:
                                    candys.PrintAllList();
                                    store.ReturnToStore();
                                    break;
                                case 2:
                                    meats.PrintAllList();
                                    store.ReturnToStore();
                                    break;
                                case 3:
                                    drinks.PrintAllList();
                                    store.ReturnToStore();
                                    break;
                                case 4:
                                    vegetables.PrintAllList();
                                    store.ReturnToStore();
                                    break;
                                case 5:
                                    HaveMoney = false;
                                    break;
                                default:
                                    Console.WriteLine("No such command, press enter to continue");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered not the number, press enter to continue");
                            Console.ReadKey();
                        }
                    }
                }
                else if (HaveMoney == true && WalletSize > 0)
                {
                    while(HaveMoney)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to store");
                        Console.WriteLine("What you want to buy?");
                        Console.WriteLine(" 1 - Candy products;");
                        Console.WriteLine(" 2 - Meat products");
                        Console.WriteLine(" 3 - Drinks products");
                        Console.WriteLine(" 4 - Vegetable products");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(" 5 - View list off products in your basket");
                        Console.WriteLine(" 6 - Pay for products;");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(" 7 - Exit store");
                        if (Int32.TryParse(Console.ReadLine(), out int inputNumber))
                        {
                            switch (inputNumber)
                            {
                                case 1:
                                    store.AddingProductsToCart(candys, Cart);
                                    store.ReturnToStore();
                                    break;
                                case 2:
                                    store.AddingProductsToCart(meats, Cart);
                                    store.ReturnToStore();
                                    break;
                                case 3:
                                    store.AddingProductsToCart(drinks, Cart);
                                    store.ReturnToStore();
                                    break;
                                case 4:
                                    store.AddingProductsToCart(vegetables, Cart);
                                    store.ReturnToStore();
                                    break;
                                case 5:
                                    Console.WriteLine("------------------");
                                    Cart.PrintAllList();
                                    Console.WriteLine("-----end list-----");
                                    store.ReturnToStore();
                                    break;
                                case 6:
                                    double totalPrice = ShoppingCartRepository.GenerateCheck(Cart.ShoppCart);
                                    if (totalPrice > WalletSize)
                                    {
                                        Console.WriteLine("You do not have enough money");
                                        store.ReturnToStore();
                                        HaveMoney = false;
                                        break;
                                    }
                                    else
                                    {
                                        var mail = new Mail();
                                        Mail.EmailSend();
                                    }
                                    HaveMoney = false;
                                    store.ReturnToStore();
                                    break;
                                case 7:
                                    HaveMoney = false;
                                    store.ReturnToStore();
                                    break;
                                default:
                                    Console.WriteLine("No such command, press enter to continue");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    HaveMoney = false;
                    continue;
                }

            }
            
        }
        

    }
}
