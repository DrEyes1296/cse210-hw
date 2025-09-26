// W03 Project: Scripture Memorizer
// Author: Edson Reyes
// To go beyond the core requirements for this project, I've added a few features to make the program more dynamic and user-friendly:
//
// 1.  **External Scripture Library:** Instead of having just one scripture baked into the code, this program loads a whole list of them from an external file ('scriptures.txt').
//     This is great because it means you or anyone else can easily add, remove, or change the scriptures without ever touching the source code.
//
// 2.  **Random Scripture Selection:** To keep things interesting, the program picks a scripture at random from the library every time you start it up. This makes for great practice and a little bit of variety.
//
// 3.  **Smarter Word Hiding:** I made the logic a bit more intelligent so that it only tries to hide words that are currently visible. This prevents it from picking a word that's already been replaced with underscores, ensuring that you're always making progress with each press of the Enter key.


using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();

        if (scripture == null)
        {
            Console.WriteLine("Could not load any scriptures. Please check the scriptures.txt file.");
            return;
        }

        string userInput = "";
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGood job!");
    }
}