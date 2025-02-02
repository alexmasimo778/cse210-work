public class Video
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds

    // List to store comments
    private List<Comment> comments = new List<Comment>();

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the total number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to display video details and comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var comment in comments)
        {
            Console.WriteLine($"  - {comment.Commenter}: {comment.Text}");
        }

        Console.WriteLine(); // Adds a blank line for readability
    }
}








