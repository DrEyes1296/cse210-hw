using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Generate a random number from 1 to 100.

        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        // 2. Add a loop as long as the guess does not match the magic number.
        while (guess != magicNumber)
        {
            // Ask the user for their guess.
            Console.Write(" Hi there! What is your guess? ");

            // Read the user's input from the console and convert it to an integer.
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            // 3. Use an if statement to determine if the guess is higher, lower, or correct.
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                // The message when the guess matches the magic number.
                Console.WriteLine("You guessed it correctly!");
            }
        }
    }
}