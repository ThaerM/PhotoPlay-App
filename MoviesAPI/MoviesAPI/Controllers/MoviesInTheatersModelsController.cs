using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesInTheatersModelsController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public MoviesInTheatersModelsController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/MoviesInTheatersModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MoviesInTheaters>>> GetMoviesInTheaters()
        {
            return await _context.MoviesInTheaters.ToListAsync();
        }

        // GET: /api/MoviesInTheatersModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MoviesInTheaters>> GetMoviesInTheatersModel(int id)
        {
            var moviesInTheatersModel = await _context.MoviesInTheaters.FindAsync(id);

            if (moviesInTheatersModel == null)
            {
                return NotFound();
            }

            return moviesInTheatersModel;
        }

        // PUT: api/MoviesInTheatersModels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoviesInTheatersModel(int id, MoviesInTheaters moviesInTheatersModel)
        {
            if (id != moviesInTheatersModel.id)
            {
                return BadRequest();
            }

            _context.Entry(moviesInTheatersModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesInTheatersModelExists(id))
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

        // POST: api/MoviesInTheatersModels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MoviesInTheaters>> PostMoviesInTheatersModel(MoviesInTheaters moviesInTheatersModel)
        {
            _context.MoviesInTheaters.Add(moviesInTheatersModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoviesInTheatersModel", new { id = moviesInTheatersModel.id }, moviesInTheatersModel);
        }

        // DELETE: api/MoviesInTheatersModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MoviesInTheaters>> DeleteMoviesInTheatersModel(int id)
        {
            var moviesInTheatersModel = await _context.MoviesInTheaters.FindAsync(id);
            if (moviesInTheatersModel == null)
            {
                return NotFound();
            }

            _context.MoviesInTheaters.Remove(moviesInTheatersModel);
            await _context.SaveChangesAsync();

            return moviesInTheatersModel;
        }

        private bool MoviesInTheatersModelExists(int id)
        {
            return _context.MoviesInTheaters.Any(e => e.id == id);
        }
    }
}
