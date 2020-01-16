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
    public class TopRatedMovies1ModelController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public TopRatedMovies1ModelController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/TopRatedMovies1Model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopRatedMovies1>>> GetTopRatedMovies1Model()
        {
            return await _context.topRatedMovies1.ToListAsync();
        }

        // GET: api/TopRatedMovies1Model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TopRatedMovies1>> GetTopRatedMovies1Model(int id)
        {
            var topRatedMovies1Model = await _context.topRatedMovies1.FindAsync(id);

            if (topRatedMovies1Model == null)
            {
                return NotFound();
            }

            return topRatedMovies1Model;
        }

        // PUT: api/TopRatedMovies1Model/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopRatedMovies1Model(int id, TopRatedMovies1 topRatedMovies1Model)
        {
            if (id != topRatedMovies1Model.id)
            {
                return BadRequest();
            }

            _context.Entry(topRatedMovies1Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopRatedMovies1ModelExists(id))
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

        // POST: api/TopRatedMovies1Model
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TopRatedMovies1>> PostTopRatedMovies1Model(TopRatedMovies1 topRatedMovies1Model)
        {
            _context.topRatedMovies1.Add(topRatedMovies1Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopRatedMovies1Model", new { id = topRatedMovies1Model.id }, topRatedMovies1Model);
        }

        // DELETE: api/TopRatedMovies1Model/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopRatedMovies1>> DeleteTopRatedMovies1Model(int id)
        {
            var topRatedMovies1Model = await _context.topRatedMovies1.FindAsync(id);
            if (topRatedMovies1Model == null)
            {
                return NotFound();
            }

            _context.topRatedMovies1.Remove(topRatedMovies1Model);
            await _context.SaveChangesAsync();

            return topRatedMovies1Model;
        }

        private bool TopRatedMovies1ModelExists(int id)
        {
            return _context.topRatedMovies1.Any(e => e.id == id);
        }
    }
}
