public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = null;
    }
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetCommentCount()
    {
        int commentCount = 0;
        foreach (Comment comment in _comments)
        {
            commentCount++;
        }

        return commentCount;
    }

    public void DisplayVideoInfo()
    {
        int commentQuantity = GetCommentCount();
        Console.WriteLine($"{_title}\nby {_author}\n{_length} seconds\n{commentQuantity} comments");
        foreach (Comment comment in _comments)
        {
            string commenter = comment.GetPerson();
            string commentContent = comment.GetText();
            Console.WriteLine($"Comment by {commenter}:\n{commentContent}");
        }
    }
}