public class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> _comments = new List<Comment>();

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to display video information along with associated comments
    public void DisplayVideoWithComments()
    {
        Console.WriteLine($"Video: {_title} by {_author}");
        Console.WriteLine("Comments:");

        // Display all comments associated with the video
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}
