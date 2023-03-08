using System;


class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();

        Console.WriteLine("Welcome to the Scripture Memorizer\n");
        Console.WriteLine("Enter '1' to choose a random verse.");
        Console.WriteLine("Enter '2' to choose your own verse. ");
        string input = Console.ReadLine();


        if (input == "1")
        {
            book.ChooseScripture();
        }
        else
        {
            book.InputNewScripture();
        }

        Scripture scripture = new Scripture(book.GetScripture());

        scripture.DisplayScripture();
        Console.WriteLine("\n\nPress enter to hide words or input 'quit' to exit. ");
        input = Console.ReadLine();
        
        while (input != "quit")
        {
            Console.Clear();
            scripture.HideWords();
            scripture.DisplayScripture();

            Console.WriteLine("\n\nPress enter to hide words ot input 'quit' to exit. ");
            input = Console.ReadLine();
        }
    }
}