namespace NotetakingApp;

using System;
// singleton, factory, adapter patterns
class Program
{
    private static string[] inputs = new string[2];
    static void Main(string[] args)
    {
        Console.WriteLine("enter note title:");
        inputs[0] = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("enter note:");
        inputs[1] = Console.ReadLine();
        // singleton pattern
        NoteHandlerFactory noteHandlerFactory = new(FileWriter.GetWriter());
        // factory pattern
        var noteHandler = noteHandlerFactory.GetNoteHandler();
        // adapter pattern
        var adapter = new FileWriterAdapter(noteHandler);
        adapter.WriteToFile(inputs);
        Console.Clear();
        Console.WriteLine("note recorded!");
    }
}