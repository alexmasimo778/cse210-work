using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine(); // Read input as string

            if (int.TryParse(input, out int choice))  // Validate input
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Starting Breathing Activity...");
                        // Call BreathingActivity() function here
                        break;

                    case 2:
                        Console.WriteLine("Starting Reflection Activity...");
                        // Call ReflectionActivity() function here
                        break;

                    case 3:
                        Console.WriteLine("Starting Listing Activity...");
                        // Call ListingActivity() function here
                        break;

                    case 4:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;  // Exit the program

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1-4).");
            }
        }
    }
}

