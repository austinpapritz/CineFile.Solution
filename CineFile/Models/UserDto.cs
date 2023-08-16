using System.Text.Json.Serialization;

namespace CineFile.Models;

public class UserDto
{
    public int UserId { get; set; }
    public string Username { get; set; }
}
