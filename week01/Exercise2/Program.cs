using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Ask for the user's grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();

        // Parse or convert the input into an integer
        if (int.TryParse(input, out int marks))
        {
            Console.WriteLine($"Your percentage grade is {marks}%");

            // providing the letter grade
            string grade;
            if (marks >= 90)
            {
                grade = "A";
            }
            else if (marks >= 80)
            {
                grade = "B";
            }
            else if (marks >= 70)
            {
                grade = "C";
            }
            else if (marks >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            //Determining the sign 
            string Sign = ""; // Default value for Sign
if (marks >= 60 && marks <= 100) // Ensure marks are in range for letter grades
{
    if (marks % 10 >= 7) // Last digit >= 7
    {
        Sign = "+";
    }
    else if (marks % 10 <= 3) // Last digit <= 3
    {
        Sign = "-";
    }
}

            // Display the grade in the output
            Console.WriteLine($"Your letter grade is: {grade}{Sign}");

            //comment on grades
            if (marks >= 70)
            {
                Console.WriteLine("Congratulations!Thanks for passing the assignments.");
            }
            else
            {
                Console.WriteLine("You just need to give more time. you cna perform better!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
