// W05 Project: Mindfulness Program - Edson Reyes

// --- EXCEEDING REQUIREMENTS ---
// To exceed requirements, I have implemented a system to ensure that random
// prompts and questions in the Reflection and Listing activities do not repeat
// until all available options have been used at least once in a single session.
// This provides a better user experience by avoiding duplicate content.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectionActivity reflecting = new ReflectionActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    Thread.Sleep(2000); // Pause to let the user read the message
                    break;
            }
        }
    }
}