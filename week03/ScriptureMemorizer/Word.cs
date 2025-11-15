using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Return the display text: either original or underscores matching letters
    public string GetDisplayText()
    {
        if (!_isHidden)
            return _text;

        // Replace letters by underscores but preserve punctuation.
        var sb = new StringBuilder();
        foreach (char c in _text)
        {
            // Treat letters and digits as hideable characters; punctuation stays
            if (char.IsLetterOrDigit(c))
                sb.Append('_');
            else
                sb.Append(c);
        }
        return sb.ToString();
    }
}
