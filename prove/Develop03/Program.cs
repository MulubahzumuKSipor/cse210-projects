using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the scripture
        Reference reference = new Reference("Exodus", 20, 8, 9);
        string scriptureText =
            "Remember the sabbath day, to keep it holy. Six days shalt thou labour, and do all thy work.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main program loop
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        // Final display
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("\nAll words have been hidden. Program ending.");
    }
}
