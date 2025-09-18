// W02 Project: Journal Program - Edson Reyes
// I have exceeded requirements. They are described below: 
// 1. Added a custom separator (~|~) for saving/loading to better handle commas in user input.
// 2. Included error handling for file operations to prevent crashes if a file doesn't exist.
// 3. Added a friendly welcome and goodbye message for a better user experience.

using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new entry
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                
                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = randomPrompt,
                    _entryText = entryText
                };
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved successfully!");
            }
            else if (choice == "2")
            {
                // Display the journal
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save the journal to a file
                Console.Write("What is the filename to save to? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                // Load the journal from a file
                Console.Write("What is the filename to load from? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                // Exit
                Console.WriteLine("Goodbye! Thanks for using the Journal Program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
        }
    }
}