using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Construct from a reference and the full text (text will be split into words)
    public Scripture(Reference reference, string fullText)
    {
        _reference = reference;
        _random = new Random();
        _words = new List<Word>();

        // Split on spaces and preserve punctuation as part of the "word"
        var tokens = fullText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var token in tokens)
        {
            _words.Add(new Word(token));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        Console.WriteLine();

        // Print words separated by spaces
        for (int i = 0; i < _words.Count; i++)
        {
            Console.Write(_words[i].GetDisplayText());
            if (i < _words.Count - 1) Console.Write(" ");
        }
        Console.WriteLine("\n");
    }

    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    // Hide up to 'count' random words. By default we pick only from words that are currently visible.
    public void HideRandomWords(int count = 3)
    {
        var visibleIndices = _words
            .Select((w, idx) => new { w, idx })
            .Where(x => !x.w.IsHidden)
            .Select(x => x.idx)
            .ToList();

        if (visibleIndices.Count == 0)
            return;

        // Hide up to 'count' distinct visible words
        int toHide = Math.Min(count, visibleIndices.Count);

        for (int i = 0; i < toHide; i++)
        {
            int pickIndex = _random.Next(visibleIndices.Count);
            int wordIndex = visibleIndices[pickIndex];

            _words[wordIndex].Hide();

            // remove chosen index so we don't pick it again in this pass
            visibleIndices.RemoveAt(pickIndex);

            if (visibleIndices.Count == 0)
                break;
        }
    }
}
