using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson15.Modules
{
    public class DrinksRepository
    {
        readonly FileReaderService Reader = new ("DrinksList.csv");
        public List<Drinks> DrinksList { get; set; }

        public DrinksRepository()
        {
            DrinksList = ReadAllDrinksFile();
        }

        private List<Drinks> ReadAllDrinksFile()
        {
            var drinkProducts = new List<Drinks>();
            List<string> allLinesFromFile = Reader.GetAllLines();
            for (int i = 0; i < allLinesFromFile.Count; i++)
            {
                var drinks = new Drinks();
                string[] temp = allLinesFromFile[i].Split(",");
                drinks.Name = temp[0];
                drinks.Barcode = Convert.ToInt32(temp[1]);
                drinks.Litters = Convert.ToDouble(temp[2], CultureInfo.InvariantCulture);
                drinks.Price = Convert.ToDouble(temp[3], CultureInfo.InvariantCulture);
                drinks.Type = temp[4];
                drinkProducts.Add(drinks);
            }

            return drinkProducts;
        }
        public void PrintAllList()
        {
            foreach (var drink in DrinksList)
            {
                Console.WriteLine($"No.{DrinksList.IndexOf(drink)+1} - {drink}");
            }
        }
    }
}
