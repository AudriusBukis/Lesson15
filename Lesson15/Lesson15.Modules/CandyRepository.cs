using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class CandyRepository
    {
        FileReaderService Reader = new FileReaderService("CandyList.csv");
        public List<Candy> CandyList { get; set; }

        public CandyRepository()
        {
            CandyList = ReadAllCandysFile();
        }

        private List<Candy> ReadAllCandysFile()
        {
            var listCandy = new List<Candy>();
            List<string> alllinesFromfile = Reader.GetAllLines();
            for (int i = 0; i < alllinesFromfile.Count; i++)
            {
                var candy = new Candy();
                string[] tepm = alllinesFromfile[i].Split(",");
                candy.Name = tepm[0];
                candy.Barcode = Convert.ToInt32(tepm[1]);
                candy.Weight = Convert.ToDouble(tepm[2], CultureInfo.InvariantCulture);
                candy.Price = Convert.ToDouble(tepm[3], CultureInfo.InvariantCulture);
                candy.SugarAmount = tepm[4];
                listCandy.Add(candy);
            }

            return listCandy;
        }
        public void PrintAllList()
        {
            foreach (var candy in CandyList)
            {
                Console.WriteLine($"No.{CandyList.IndexOf(candy)} - {candy}");
            }
        }

    }
}
