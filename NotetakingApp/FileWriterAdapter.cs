using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotetakingApp
{
    internal class FileWriterAdapter
    {
        private NoteHandler _noteHandler;
        public FileWriterAdapter(NoteHandler noteHandler)
        {
            _noteHandler = noteHandler;
        }

        public async void WriteToFile(string[] text)
        {
            string adaptedText = "";
            foreach (string line in text)
                adaptedText += line;

            _noteHandler.WriteNote(adaptedText);
        }

    }
}
