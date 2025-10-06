// Edson Reyes - CSE 210
// W04 Assignment: YouTube Video Program

// Keeps track of the video's details and a list of its comments.
public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    
    // A list to hold all the Comment objects for this video.
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Adds a new comment to this video's list.
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        _comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}