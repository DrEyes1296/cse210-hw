using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user and get their grade percentage.
            Console.Write("Hi there! Please enter your grade percentage: ");
            string userInput = Console.ReadLine();
            int gradePercent = int.Parse(userInput);

            string letter;
            string sign = "";

            // --- Determine the Letter Grade ---
            if (gradePercent >= 90)
            {
                letter = "A";
            }
            else if (gradePercent >= 80)
            {
                letter = "B";
            }
            else if (gradePercent >= 70)
            {
                letter = "C";
            }
            else if (gradePercent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // --- Determine the Plus/Minus Sign ---
            int lastDigit = gradePercent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // --- Apply Special Grading Rules ---
            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
            if (letter == "F")
            {
                sign = "";
            }

            // --- Display the Results ---
            Console.WriteLine($"Your final grade is: {letter}{sign}");

            // Confirm and Let the student know if they passed or failed.
            if (gradePercent >= 70)
            {
                Console.WriteLine("Congratulations! You have passed the course!");
            }
            else
            {
                Console.WriteLine("Keep trying! You'll get it next time.");
            }
        }
    }
}