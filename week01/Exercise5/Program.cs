using System;

namespace Exercise5
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // Display the welcome message.
            DisplayWelcome();

            // Get the user's name and store it in a variable.
            string userName = PromptUserName();

            // Get the user's favorite number and store it.
            int userNumber = PromptUserNumber();

            // Call the function to square the number.
            int squaredNumber = SquareNumber(userNumber);

            // Call the function to display the final result.
            DisplayResult(userName, squaredNumber);
        }

        // Function to display a welcome message to the user.
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello! Welcome to the Program!");
        }

        // A function asking for the user's name.
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // A function asking for the user's favorite number.
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // A function to calculate the square of a number.
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // A function to display the final result.
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}