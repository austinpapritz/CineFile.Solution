using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CineFile.Models;

namespace CineFile.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly CineFileContext _db;

    public MoviesController(CineFileContext db)
    {
        _db = db;
    }

    // GET: api/Movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies(string? title, string? genre)
    {
        IQueryable<Movie> query = _db.Movies.AsQueryable();

        if (title != null)
        {
            query = query.Where(entry => entry.Title == title);
        }

        if (genre != null)
        {
            query = query.Where(entry => entry.Genre == genre);
        }

        if (title == null && genre == null)
        {
            return await _db.Movies.ToListAsync();
        }

        return await query.ToListAsync();
    }

    // GET: api/Movies/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovieById(int id)
    {
        Movie movie = await _db.Movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        return movie;
    }

    // POST api/movies
    [HttpPost]
    public async Task<ActionResult<Movie>> Post(Movie movie)
    {
        _db.Movies.Add(movie);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMovieById), new { id = movie.MovieId }, movie);
    }

    // PUT: api/movies/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Movie movie)
    {
        if (id != movie.MovieId)
        {
            return BadRequest();
        }

        _db.Movies.Update(movie);

        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MovieExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/movies/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        Movie movie = await _db.Movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        _db.Movies.Remove(movie);
        await _db.SaveChangesAsync();

        return NoContent();
    }

    private bool MovieExists(int id)
    {
        return _db.Movies.Any(e => e.MovieId == id);
    }

    // Get route for comments by MovieId
    // GET: api/Movies/5/Comments
    [HttpGet("{MovieId}/Comments")]
    public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsByMovieId(int MovieId)
    {
        // Grab list of movies that match the MovieId parameter.
        List<Comment> query = await _db.Comments.Where(c => c.MovieId == MovieId).Include(c => c.User).ToListAsync();
        return query;
    }

    // Post route for user commenting on a movie
}
