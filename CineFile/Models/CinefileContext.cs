using Microsoft.EntityFrameworkCore;

namespace CineFile.Models;

public class CineFileContext : DbContext
{
  public DbSet<Movie> Movies { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Comment> Comments { get; set; }

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

    builder.Entity<User>()
        .HasData(
            new User { UserId = 1, Username = "User1", Pasword = "password123" },
            new User { UserId = 2, Username = "User2", Pasword = "password123" },
            new User { UserId = 3, Username = "User3", Pasword = "password123" },
            new User { UserId = 4, Username = "User4", Pasword = "password123" },
            new User { UserId = 5, Username = "User5", Pasword = "password123" }
        );


    builder.Entity<Comment>()
        .HasData(
            // User 1 comments
            new Comment { CommentId = 1, Content = "User1's comment on Matilda", DatePosted = DateTime.Now, UserId = 1, MovieId = 1 },
            new Comment { CommentId = 2, Content = "User1's comment on Ironman", DatePosted = DateTime.Now, UserId = 1, MovieId = 2 },
            new Comment { CommentId = 3, Content = "User1's comment on Edward Scissorhands", DatePosted = DateTime.Now, UserId = 1, MovieId = 3 },
            new Comment { CommentId = 4, Content = "User1's comment on Pippy Longstocking", DatePosted = DateTime.Now, UserId = 1, MovieId = 4 },
            new Comment { CommentId = 5, Content = "User1's comment on John Wick 2", DatePosted = DateTime.Now, UserId = 1, MovieId = 5 },

            // User 2 comments
            new Comment { CommentId = 6, Content = "User2's comment on Matilda", DatePosted = DateTime.Now, UserId = 2, MovieId = 1 },
            new Comment { CommentId = 7, Content = "User2's comment on Ironman", DatePosted = DateTime.Now, UserId = 2, MovieId = 2 },
            new Comment { CommentId = 8, Content = "User2's comment on Edward Scissorhands", DatePosted = DateTime.Now, UserId = 2, MovieId = 3 },
            new Comment { CommentId = 9, Content = "User2's comment on Pippy Longstocking", DatePosted = DateTime.Now, UserId = 2, MovieId = 4 },
            new Comment { CommentId = 10, Content = "User2's comment on John Wick 2", DatePosted = DateTime.Now, UserId = 2, MovieId = 5 },

            // User 3 comments 
            new Comment { CommentId = 11, Content = "User3's comment on Matilda", DatePosted = DateTime.Now, UserId = 3, MovieId = 1 },
            new Comment { CommentId = 12, Content = "User3's comment on Ironman", DatePosted = DateTime.Now, UserId = 3, MovieId = 2 },
            new Comment { CommentId = 13, Content = "User3's comment on Edward Scissorhands", DatePosted = DateTime.Now, UserId = 3, MovieId = 3 },
            new Comment { CommentId = 14, Content = "User3's comment on Pippy Longstocking", DatePosted = DateTime.Now, UserId = 3, MovieId = 4 },
            new Comment { CommentId = 15, Content = "User3's comment on John Wick 3", DatePosted = DateTime.Now, UserId = 3, MovieId = 5 },

            // User 4 comments 
            new Comment { CommentId = 16, Content = "User4's comment on Matilda", DatePosted = DateTime.Now, UserId = 4, MovieId = 1 },
            new Comment { CommentId = 17, Content = "User4's comment on Ironman", DatePosted = DateTime.Now, UserId = 4, MovieId = 2 },
            new Comment { CommentId = 18, Content = "User4's comment on Edward Scissorhands", DatePosted = DateTime.Now, UserId = 4, MovieId = 3 },
            new Comment { CommentId = 19, Content = "User4's comment on Pippy Longstocking", DatePosted = DateTime.Now, UserId = 4, MovieId = 4 },
            new Comment { CommentId = 20, Content = "User4's comment on John Wick 2", DatePosted = DateTime.Now, UserId = 4, MovieId = 5 },

            // User 5 comments 
            new Comment { CommentId = 21, Content = "User5's comment on Matilda", DatePosted = DateTime.Now, UserId = 5, MovieId = 1 },
            new Comment { CommentId = 22, Content = "User5's comment on Ironman", DatePosted = DateTime.Now, UserId = 5, MovieId = 2 },
            new Comment { CommentId = 23, Content = "User5's comment on Edward Scissorhands", DatePosted = DateTime.Now, UserId = 5, MovieId = 3 },
            new Comment { CommentId = 24, Content = "User5's comment on Pippy Longstocking", DatePosted = DateTime.Now, UserId = 5, MovieId = 4 },
            new Comment { CommentId = 25, Content = "User5's comment on John Wick 2", DatePosted = DateTime.Now, UserId = 5, MovieId = 5 }
        );
  }
}


