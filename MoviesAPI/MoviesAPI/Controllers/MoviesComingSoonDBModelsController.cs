using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesComingSoonDBModelsController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public MoviesComingSoonDBModelsController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/MoviesComingSoonDBModels
        [HttpGet]
        public ActionResult<IEnumerable<MoviesComingSoonDB>> GetMoviesComingSoonDBModel()
        {
            try
            {
                var userLog = _context.moviesComingSoonDB.ToList();
                return Ok(userLog);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message + "Not Found Result");
            }
        }

        // GET: api/MoviesComingSoonDBModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MoviesComingSoonDB>> GetMoviesComingSoonDBModel(int id)
        {
            var moviesComingSoonDBModel = await _context.moviesComingSoonDB.FindAsync(id);

            if (moviesComingSoonDBModel == null)
            {
                return NotFound();
            }

            return moviesComingSoonDBModel;
        }

        // PUT: api/MoviesComingSoonDBModels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoviesComingSoonDBModel(int id, MoviesComingSoonDB moviesComingSoonDBModel)
        {
            if (id != moviesComingSoonDBModel.id)
            {
                return BadRequest();
            }

            _context.Entry(moviesComingSoonDBModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesComingSoonDBModelExists(id))
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

        // POST: api/MoviesComingSoonDBModels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MoviesComingSoonDB>> PostMoviesComingSoonDBModel(MoviesComingSoonDB moviesComingSoonDBModel)
        {
            _context.moviesComingSoonDB.Add(moviesComingSoonDBModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoviesComingSoonDBModel", new { moviesComingSoonDBModel.id }, moviesComingSoonDBModel);
        }

        // DELETE: api/MoviesComingSoonDBModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MoviesComingSoonDB>> DeleteMoviesComingSoonDBModel(int id)
        {
            var moviesComingSoonDBModel = await _context.moviesComingSoonDB.FindAsync(id);
            if (moviesComingSoonDBModel == null)
            {
                return NotFound();
            }

            _context.moviesComingSoonDB.Remove(moviesComingSoonDBModel);
            await _context.SaveChangesAsync();

            return moviesComingSoonDBModel;
        }

        private bool MoviesComingSoonDBModelExists(int id)
        {
            return _context.moviesComingSoonDB.Any(e => e.id == id);
        }
    }
}
