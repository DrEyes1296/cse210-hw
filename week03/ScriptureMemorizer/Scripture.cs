using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (var wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }



    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int indexToHide = random.Next(visibleWords.Count);

            visibleWords[indexToHide].Hide();

            visibleWords.RemoveAt(indexToHide);
        }
    }




    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}