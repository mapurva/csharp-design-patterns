using MementoPattern;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        History history = new History();

        editor.Write("Hello ");
        history.Push(editor.Save());

        editor.Write("World!");
        history.Push(editor.Save());

        Console.WriteLine("Current: " + editor.GetContent());

        // Undo
        editor.Restore(history.Pop());
        Console.WriteLine("After Undo: " + editor.GetContent());

        editor.Restore(history.Pop());
        Console.WriteLine("After Second Undo: " + editor.GetContent());
    }
}