using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class FilePath
    {
        public string FileName { get; private set; }
        public string Path { get; private set; }
        public FilePath(string fileName)
        {
            FileName = fileName;
            Path = $@"C:\Users\audri\Documents\Code_Academy_mokymai\lesson15\Lesson15\Lesson15\{FileName}";
            
        }
    }
}
