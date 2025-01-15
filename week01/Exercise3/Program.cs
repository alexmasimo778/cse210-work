using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

// Main loop for playing the game multiple times
        string response;
        do
        {
// Generating a random magic number
            int magicNumber = random.Next(1, 100);
            int guesses = 0; // Counting the number of guesses

            Console.Write("Guess the magic number: ");
            bool found = false;
// Loop until the correct guess
            while (!found) 
            {
                string input = Console.ReadLine();

 // Validate and convert input
                if (int.TryParse(input, out int guess))
                {
// Increment guess count                
                    guesses++; 

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Too low! Think higher to get the correct magic number!");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Too high! Think lower to get the correct magic number!");
                    }
                    else
                    {
                        Console.WriteLine($"Correct! You have found the magic number in {guesses} guesses.");
                        found = true; // Exit the loop
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

// Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine()?.Trim().ToLower();

        } while (response == "yes");

        Console.WriteLine("Thank you!welcome for another time!");
    }
}