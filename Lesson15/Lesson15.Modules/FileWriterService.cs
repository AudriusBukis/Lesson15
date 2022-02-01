using System;
using System.IO;

namespace Lesson15.Modules
{
    public class FileWriterService : FilePath
    {
        public FileWriterService(string fileName) : base(fileName)
        {
        }

        public void AppendText(string text)
        {
            using StreamWriter sw = File.AppendText(Path);
            sw.WriteLine(text);
        }
        public void WriteAllText(string[] lines)
        {
            File.WriteAllLines(Path, lines);
        }

        public void WriteAllText(Func<string[]> toArray)
        {
            throw new NotImplementedException();
        }
    }
}
