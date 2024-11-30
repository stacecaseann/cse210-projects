using System.Reflection.Metadata.Ecma335;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public string DisplayDetails()
    {
        string details = $"{_title}, Created By {_author}, Length: {_length} seconds";

        foreach(Comment comment in _comments)
        {
            details += comment.DisplayDetails();
        }
        return details;
    }
}