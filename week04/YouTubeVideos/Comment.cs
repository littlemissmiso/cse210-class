public class Comment
{
    public string _commenterName;
    public string _commentText;

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"'{_commentText}' - {_commenterName}");
    }
}