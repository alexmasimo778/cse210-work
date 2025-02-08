using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "List positive things about your day.";
    }

    public override void Start()
    {
        Console.WriteLine($"\nStarting {Name}: {Description}");
        Console.Write("Enter the number of items you want to list: ");
        int count = int.Parse(Console.ReadLine());

        List<string> items = new List<string>();
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Item {i + 1}: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine("\nHere is what you listed:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
