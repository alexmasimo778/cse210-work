using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

    // Asking user for a series of numbers
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();

    // Splitting input into individual number strings
        string[] numberStrings = input.Split(' ');

     // List to store parsed numbers
        List<int> numbers = new List<int>();

    // Parsing and adding numbers to the list
        foreach (var numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Invalid input: '{numberString}' is not a valid number.");
            }
        }

    // Compute sum of numbers
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

    // Compute average of numbers
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

    // Find maximum number in the list
        int maxNumber = int.MinValue;
        foreach (var number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

    // Output results
        Console.WriteLine($"Sum of numbers: {sum}");
        Console.WriteLine($"Average of numbers: {average}");
        Console.WriteLine($"Maximum number: {maxNumber}");
    }
}













