using System;
using System.Collections.Generic;
using System.IO; // Required for file operations

public class Journal
{
    // Member variable to hold a list of Entry objects
    public List<Entry> _entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("--- End of Journal ---");
    }

    // Method to save the journal to a file
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    // Using a custom separator to avoid issues with commas in the text
                    outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal successfully saved to {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    // Method to load the journal from a file
    public void LoadFromFile(string file)
    {
        try
        {
            if (!File.Exists(file))
            {
                 Console.WriteLine($"File not found: {file}");
                 return;
            }

            string[] lines = File.ReadAllLines(file);
            _entries.Clear(); // Clear existing entries before loading new ones

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal successfully loaded from {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    }
}