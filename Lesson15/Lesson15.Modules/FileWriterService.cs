using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class FileWriterService : FilePath
    {
        public FileWriterService(string fileName) : base(fileName)
        {
        }

        public void AppendText(string text)
        {
            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine(text);
            }
        }
        public void WriteAllText(string[] lines)
        {
            File.WriteAllLines(Path, lines);
        }
    }
}
