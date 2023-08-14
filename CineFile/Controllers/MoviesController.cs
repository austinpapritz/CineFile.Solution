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

    // GET api/movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
    {
        return await _db.Movies.ToListAsync();
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
}
