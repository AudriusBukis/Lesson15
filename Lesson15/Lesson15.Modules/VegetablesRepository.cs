using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class VegetablesRepository
    {
        private FileReaderService Reader = new FileReaderService("VegetablesList.csv");
        public List<Vegetables> VegetablesList { get; set; }

        public VegetablesRepository()
        {
            VegetablesList = ReadAllVegetablesFile();
        }

        private List<Vegetables> ReadAllVegetablesFile()
        {
            var listVegetables = new List<Vegetables>();
            List<string> alllinesFromfile = Reader.GetAllLines();
            for (int i = 0; i < alllinesFromfile.Count; i++)
            {
                var vegetables = new Vegetables();
                string[] tepm = alllinesFromfile[i].Split(",");
                vegetables.Name = tepm[0];
                vegetables.Barcode = Convert.ToInt32(tepm[1]);
                vegetables.Weight = Convert.ToDouble(tepm[2], CultureInfo.InvariantCulture);
                vegetables.Price = Convert.ToDouble(tepm[3], CultureInfo.InvariantCulture);
                vegetables.Fibers = tepm[4];
                listVegetables.Add(vegetables);
            }

            return listVegetables;
        }
        public void PrintAllList()
        {
            foreach (var vegetable in VegetablesList)
            {
                Console.WriteLine($"No.{VegetablesList.IndexOf(vegetable)} - {vegetable}"); 
            }
        }
    }
}
