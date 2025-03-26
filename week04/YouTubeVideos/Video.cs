public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_videoLength} min");
        Console.WriteLine($"Comments: {_comments.Count}");
        Console.WriteLine();

        foreach (Comment c in _comments)
        {
            c.DisplayCommentInfo();
        }
        Console.WriteLine();
        Console.WriteLine("----------------------");
        
    }

    


    //Also needs to STORE A LIST OF COMMENTS, and have a method TO RETURN THE NUMBER OF COMMENTS
}