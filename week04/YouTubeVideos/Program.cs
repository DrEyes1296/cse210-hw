// Edson Reyes - CSE 210
// W04 Assignment: YouTube Video Program

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and set up the first video
        Video video1 = new Video("C# Tutorial for Beginners", "Tech with Tim", 1800);
        video1.AddComment("Alice", "Great tutorial, very helpful!");
        video1.AddComment("Bob", "I was confused about classes, but this cleared it up.");
        video1.AddComment("Charlie", "Can you do a video on ASP.NET next?");
        videos.Add(video1);

        // Create and set up the second video
        Video video2 = new Video("How to Cook the Perfect Steak", "Gordon Ramsay", 650);
        video2.AddComment("David", "My steak was perfect, thank you!");
        video2.AddComment("Eve", "Finally, a method that works. Delicious.");
        video2.AddComment("Frank", "Where's the lamb sauce?!");
        video2.AddComment("Grace", "Simple and effective.");
        videos.Add(video2);

        // Create and set up the third video
        Video video3 = new Video("Relaxing Rain Sounds for Sleeping", "Ambient Worlds", 36000);
        video3.AddComment("Heidi", "This helps me study for hours.");
        video3.AddComment("Ivan", "Zzzzzzz...");
        video3.AddComment("Judy", "The perfect background noise for coding.");
        videos.Add(video3);

        // Display all the videos
        Console.WriteLine("--- Displaying YouTube Video Information ---");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine(); 
        }
    }
}