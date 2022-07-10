using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotetakingApp
{
    internal class FileWriter
    {
        // singleton pattern
        private static FileWriter fileWriter { get; set; }
        private FileWriter()
        {
        }
        public static FileWriter GetWriter()
        {
            if (fileWriter == null)
                fileWriter = new FileWriter();
            return fileWriter;
        }
        public async void WriteToFile(string text)
        {
            await File.AppendAllTextAsync("Diary.txt", text);
        }
    }
}
