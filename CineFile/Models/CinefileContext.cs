using Microsoft.EntityFrameworkCore;

namespace CineFile.Models;

public class CineFileContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public CineFileContext(DbContextOptions<CineFileContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Movie>()
          .HasData(
            new Movie { MovieId = 1, Title = "Matilda", Genre = "Childrens" },
            new Movie { MovieId = 2, Title = "Ironman", Genre = "Action" },
            new Movie { MovieId = 3, Title = "Edward Scissorhands", Genre = "Romance" },
            new Movie { MovieId = 4, Title = "Pippy Longstocking", Genre = "Childrens" },
            new Movie { MovieId = 5, Title = "John Wick 2", Genre = "Action" }
          );
    }
}
