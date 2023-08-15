namespace CineFile.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Pasword { get; set; }
    public List<Comment> Comments { get; set; }
}
