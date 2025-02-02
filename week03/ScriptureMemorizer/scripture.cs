using System;
using System.Collections.Generic;
using System.Linq;

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