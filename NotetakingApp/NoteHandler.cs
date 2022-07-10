using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotetakingApp
{
    internal class NoteHandler
    {
        private FileWriter _writer;

        public NoteHandler(FileWriter writer)
        {
            _writer = writer;
        }
        public void WriteNote(string text)
        {
            _writer.WriteToFile(text);
        }
    }
}
