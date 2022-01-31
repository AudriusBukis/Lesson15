using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class MeatRepository
    {
        FileReaderService Reader = new FileReaderService("MeatList.csv");
        public List<Meat> MeatList { get; set; }

        public MeatRepository()
        {
            MeatList = ReadAllMeatFile();
        }

        private List<Meat> ReadAllMeatFile()
        {
            var listMeat = new List<Meat>();
            List<string> alllinesFromfile = Reader.GetAllLines();
            for (int i = 0; i < alllinesFromfile.Count; i++)
            {
                var meat = new Meat();
                string[] tepm = alllinesFromfile[i].Split(",");
                meat.Name = tepm[0];
                meat.Barcode = Convert.ToInt32(tepm[1]);
                meat.Weight = Convert.ToDouble(tepm[2]);
                meat.Price = Convert.ToDouble(tepm[3]);
                meat.Proteins = tepm[4];
                listMeat.Add(meat);
            }

            return listMeat;
        }
        public void PrintAllList()
        {
            foreach (var meat in MeatList)
            {
                Console.WriteLine($"No.{MeatList.IndexOf(meat)} - {meat}");
            }
        }
    }
}
