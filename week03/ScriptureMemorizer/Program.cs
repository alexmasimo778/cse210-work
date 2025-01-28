using System;
using System.Collections.Generic;
using System.Linq;

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

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Default visibility
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text; // Show the word or a blank line
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Default to single verse
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}" + (_endVerse > _verse ? $"-{_endVerse}" : "");
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        var wordList = text.Split(' '); // Split the text into words

        foreach (var word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var rand = new Random();
        int hidden = 0;
        while (hidden < numberToHide)
        {
            var index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
















