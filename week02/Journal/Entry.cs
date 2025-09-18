public class Entry
{
    // Member variables for the date, prompt, and entry text
    public string _date;
    public string _promptText;
    public string _entryText;

    // Method to display the entry in a formatted way
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}