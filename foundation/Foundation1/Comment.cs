public class Comment
{
    private string _name;
    private string _comment;

    public string DisplayDetails()
    {
        return $"{_name}: {_comment}";
    }
}