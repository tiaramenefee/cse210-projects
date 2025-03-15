public class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> _comments = new List<Comment>();

    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    
    public void DisplayVideoWithComments()
    {
        Console.WriteLine($"Video: {_title} by {_author}");
        Console.WriteLine("Comments:");

        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}
