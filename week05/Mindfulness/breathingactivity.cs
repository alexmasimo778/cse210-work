using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "Focus on breathing in and out.";
    }

    public override void Start()
    {
        Console.WriteLine($"\nStarting {Name}: {Description}");
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
        }

        Console.WriteLine("\nBreathing exercise completed!");
    }
}
