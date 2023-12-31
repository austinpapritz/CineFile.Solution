using System.Text.Json.Serialization;

namespace CineFile.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
    [JsonIgnore]
    public List<Comment> Comments { get; set; }
}
