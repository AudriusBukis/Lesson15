using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class FileReaderService : FilePath
    {
        public FileReaderService(string fileName) : base(fileName)
        {
        }

        public List<string> GetAllLines()
        {
            var lines = File.ReadAllLines(Path);
            return lines.ToList();
        }

    }
}
