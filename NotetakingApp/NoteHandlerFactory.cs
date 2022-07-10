using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotetakingApp
{
    internal class NoteHandlerFactory
    {
        private readonly FileWriter _fileWriter;

        public NoteHandlerFactory(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }
        public NoteHandler GetNoteHandler()
        {
            return new NoteHandler(_fileWriter);
        }
    }
}
