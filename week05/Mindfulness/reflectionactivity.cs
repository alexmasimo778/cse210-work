using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment when you felt truly grateful.",
        "Describe an event that made you stronger."
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "Reflect on positive moments in your life.";
    }

    public override void Start()
    {
        Console.WriteLine($"\nStarting {Name}: {Description}");
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Take a moment to reflect. Press Enter when ready...");
        Console.ReadLine();

        Console.WriteLine("Reflection completed!");
    }
}