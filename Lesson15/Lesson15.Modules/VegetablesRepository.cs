using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson15.Modules
{
    public class VegetablesRepository
    {
        readonly FileReaderService Reader = new ("VegetablesList.csv");
        public List<Vegetables> VegetablesList { get; set; }

        public VegetablesRepository()
        {
            VegetablesList = ReadAllVegetablesFile();
        }

        private List<Vegetables> ReadAllVegetablesFile()
        {
            var vegetableProduct = new List<Vegetables>();
            List<string> allLinesFromFile = Reader.GetAllLines();
            for (int i = 0; i < allLinesFromFile.Count; i++)
            {
                var vegetables = new Vegetables();
                string[] tepm = allLinesFromFile[i].Split(",");
                vegetables.Name = tepm[0];
                vegetables.Barcode = Convert.ToInt32(tepm[1]);
                vegetables.Weight = Convert.ToDouble(tepm[2], CultureInfo.InvariantCulture);
                vegetables.Price = Convert.ToDouble(tepm[3], CultureInfo.InvariantCulture);
                vegetables.Fibers = tepm[4];
                vegetableProduct.Add(vegetables);
            }

            return vegetableProduct;
        }
        public void PrintAllList()
        {
            foreach (var vegetable in VegetablesList)
            {
                Console.WriteLine($"No.{VegetablesList.IndexOf(vegetable)+1} - {vegetable}"); 
            }
        }
    }
}
