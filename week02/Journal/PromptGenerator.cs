public class PromptGenerator
{
    // Member variable for the list of prompts
    public List<string> _prompts;

    // Constructor to initialize the prompt list
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is your biggest fear, and is it holding you back?",
            "What do you love about your body, mind, and personality?",
            "What do I need more or less of in my life?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something that made you laugh today?",
            "What is a simple pleasure you enjoyed today?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
