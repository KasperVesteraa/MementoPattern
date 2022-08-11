using System;

namespace MementoPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Editor editor = new Editor();
            History history = new History();
            
            editor.Content = "Kasper Westeraa";
            history.Push(editor.CreateState());
            
            editor.Content = "Kasper Westeraa er en flot fyr";
            history.Push(editor.CreateState());

            editor.Content = "Kasper Westeraa er en flot fyr, der kører ellert";
            Console.WriteLine(editor.Content);
            
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

        }
    }
}