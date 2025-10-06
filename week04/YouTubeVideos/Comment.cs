// Edson Reyes - CSE 210
// W04 Assignment: YouTube Video Program

// A simple class to hold the information for a single comment.
public class Comment
{
    public string _commenterName;
    public string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"  > {_commenterName}: \"{_commentText}\"");
    }
}