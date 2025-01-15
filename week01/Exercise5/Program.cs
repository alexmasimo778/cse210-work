using System;

class Program
{
    static void Main(string[] args)
    {
// Display Welcome Message
        Console.WriteLine("You are Welcome!");

// Asking for the username and return it
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        Console.WriteLine($"{username}");

// Asking for the user's favorite number and return it
        Console.Write("What is your favorite number? ");
        int favoriteNumber;
        while (!int.TryParse(Console.ReadLine(), out favoriteNumber))
        {
            Console.Write("Please enter a valid integer: ");
        }
        Console.WriteLine($"Your favorite number is {favoriteNumber}.");

// Accepting an integer as a parameter, return its square, and display it
        int squaredValue = CalculateSquare(favoriteNumber);
        Console.WriteLine($"Your favorite number is {favoriteNumber}");
        Console.WriteLine($"The square of your favorite number  is {squaredValue}.");
    }

// Method to calculate the square of a number
    static int CalculateSquare(int number)
    {
        return number * number;
    }
}










