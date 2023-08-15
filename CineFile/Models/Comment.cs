namespace CineFile.Models;
public class Comment
{
    public int CommentId { get; set; }
    public string Content { get; set; }
    public DateTime DatePosted { get; set; }
    public int UserId { get; set; } // Foreign Key for User
    public User User { get; set; }
    public int MovieId { get; set; } // Foreign Key for Movie
    public Movie Movie { get; set; }
}
