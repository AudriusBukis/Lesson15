using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson15.Modules
{
    public class MeatRepository
    {
        readonly FileReaderService Reader = new ("MeatList.csv");
        public List<Meat> MeatList { get; set; }

        public MeatRepository()
        {
            MeatList = ReadAllMeatFile();
        }

        private List<Meat> ReadAllMeatFile()
        {
            var meatProducts = new List<Meat>();
            List<string> allLinesFromFile = Reader.GetAllLines();
            for (int i = 0; i < allLinesFromFile.Count; i++)
            {
                var meat = new Meat();
                string[] temp = allLinesFromFile[i].Split(",");
                meat.Name = temp[0];
                meat.Barcode = Convert.ToInt32(temp[1]);
                meat.Weight = Convert.ToDouble(temp[2], CultureInfo.InvariantCulture);
                meat.Price = Convert.ToDouble(temp[3], CultureInfo.InvariantCulture);
                meat.Proteins = temp[4];
                meatProducts.Add(meat);
            }

            return meatProducts;
        }
        public void PrintAllList()
        {
            foreach (var meat in MeatList)
            {
                Console.WriteLine($"No.{MeatList.IndexOf(meat)+1} - {meat}");
            }
        }
    }
}
