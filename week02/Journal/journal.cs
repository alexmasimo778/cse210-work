
using System;
using System.Collections.Generic;
using System.IO;

//Creating journal class:
public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private static Random random = new Random();
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry(string response)
    {
        string prompt = prompts[random.Next(prompts.Count)];
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        JournalEntry entry = new JournalEntry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }
//saving to file newfile the data entry
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new JournalEntry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()));
            }
        }
    }
}
