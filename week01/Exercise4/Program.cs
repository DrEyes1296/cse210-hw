using System.Collections.Generic;

using System.Linq;

// Create a list to store the numbers.
List<int> numbers = new List<int>();

// User Input Loop

Console.WriteLine("Enter a list of numbers, type 0 when finished.");
int userNumber = -1;

// I keep asking for numbers until the user enters 0.
while (userNumber != 0)
{
    Console.Write("Enter number: ");

    // Read the user's input and convert it from a string to an integer.
    userNumber = int.Parse(Console.ReadLine());

    // Only add the number to the list if it is not 0.
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}

// --- Calculations and Output ---

// Here, I ensure that the user entered at least one number before trying to calculate.
if (numbers.Count > 0)
{
    // 1. Compute the sum
    // The .Sum() method from LINQ adds up all the items in the list.
    int sum = numbers.Sum();
    Console.WriteLine($"The sum is: {sum}");

    // 2. Compute the average
    double average = numbers.Average();
    Console.WriteLine($"The average is: {average}");

    // 3. Find the maximum number
    int maxNumber = numbers.Max();
    Console.WriteLine($"The largest number is: {maxNumber}");
}
else
{
    Console.WriteLine("No numbers were entered.");
}
