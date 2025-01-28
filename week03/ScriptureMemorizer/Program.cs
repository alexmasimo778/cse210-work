using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Example of creating a reference for a scripture.
        var reference = new Reference("John", 3, 16);

        // Creating a scripture with the reference and a sample text.
        var scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

        // Displaying the reference text
        Console.WriteLine("Scripture Reference: " + reference.GetDisplayText());

        // Displaying the scripture text
        Console.WriteLine("Scripture Text: " + scripture.GetDisplayText());

        // Hiding 3 random words in the scripture
        scripture.HideRandomWords(3);

        // Displaying the scripture text after hiding words
        Console.WriteLine("Scripture Text (After Hiding Words): " + scripture.GetDisplayText());

        // Checking if all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden!");
        }
        else
        {
            Console.WriteLine("There are still visible words.");
        }
    }
}
















