using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson15.Modules
{
    public class CandyRepository
    {
        readonly FileReaderService Reader = new("CandyList.csv");
        public List<Candy> CandyList { get; set; }

        public CandyRepository()
        {
            CandyList = ReadAllCandysFile();
        }

        private List<Candy> ReadAllCandysFile()
        {
            var candyProducts = new List<Candy>();
            List<string> allLinesFromFile = Reader.GetAllLines();
            for (int i = 0; i < allLinesFromFile.Count; i++)
            {
                var candy = new Candy();
                string[] temp = allLinesFromFile[i].Split(",");
                candy.Name = temp[0];
                candy.Barcode = Convert.ToInt32(temp[1]);
                candy.Weight = Convert.ToDouble(temp[2], CultureInfo.InvariantCulture);
                candy.Price = Convert.ToDouble(temp[3], CultureInfo.InvariantCulture);
                candy.SugarAmount = temp[4];
                candyProducts.Add(candy);
            }

            return candyProducts;
        }
        public void PrintAllList()
        {
            foreach (var candy in CandyList)
            {
                Console.WriteLine($"No.{CandyList.IndexOf(candy)+1} - {candy}");
            }
        }

    }
}
