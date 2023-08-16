using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CineFile.Models;

public class Movie
{
    public int MovieId { get; set; }
    [Required]
    [StringLength(20)]
    public string Title { get; set; }
    [StringLength(20)]
    public string Genre { get; set; }
    [JsonIgnore]
    List<Comment> Comments { get; set; }
}
