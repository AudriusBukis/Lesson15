using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class DrinksRepository
    {
        FileReaderService Reader = new FileReaderService("DrinksList.csv");
        public List<Drinks> DrinksList { get; set; }

        public DrinksRepository()
        {
            DrinksList = ReadAllDrinksFile();
        }

        private List<Drinks> ReadAllDrinksFile()
        {
            var listDrinks = new List<Drinks>();
            List<string> alllinesFromfile = Reader.GetAllLines();
            for (int i = 0; i < alllinesFromfile.Count; i++)
            {
                var drinks = new Drinks();
                string[] tepm = alllinesFromfile[i].Split(",");
                drinks.Name = tepm[0];
                drinks.Barcode = Convert.ToInt32(tepm[1]);
                drinks.Litters = Convert.ToDouble(tepm[2]);
                drinks.Price = Convert.ToDouble(tepm[3]);
                drinks.Type = tepm[4];
                listDrinks.Add(drinks);
            }

            return listDrinks;
        }
        public void PrintAllList()
        {
            foreach (var drink in DrinksList)
            {
                Console.WriteLine($"No.{DrinksList.IndexOf(drink)} - {drink}");
            }
        }
    }
}
