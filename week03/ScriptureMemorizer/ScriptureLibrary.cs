using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private readonly List<Scripture> _scriptures;
    private readonly Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScripturesFromFile("scriptures.txt");
    }

    private void LoadScripturesFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                
                string[] parts = line.Split('|');
                if (parts.Length != 2) continue;

                string referenceString = parts[0];
                string text = parts[1];

                Reference reference = ParseReference(referenceString);

                if (reference != null)
                {
                    _scriptures.Add(new Scripture(reference, text));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
    }

    private Reference ParseReference(string referenceString)
    {
        try
        {
        
            string[] parts = referenceString.Trim().Split(' ');
            string book = parts[0];

            
            string[] verseParts = parts[1].Split(':');
            int chapter = int.Parse(verseParts[0]);

            if (verseParts[1].Contains("-"))
            {
                string[] verses = verseParts[1].Split('-');
                int startVerse = int.Parse(verses[0]);
                int endVerse = int.Parse(verses[1]);
                return new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                int verse = int.Parse(verseParts[1]);
                return new Reference(book, chapter, verse);
            }
        }
        catch (Exception)
        {
        
            Console.WriteLine($"Could not parse reference: {referenceString}");
            return null;
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            return null;
        }
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
