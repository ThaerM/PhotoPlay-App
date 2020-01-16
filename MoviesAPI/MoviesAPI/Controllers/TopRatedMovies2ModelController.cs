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
    public class TopRatedMovies2ModelController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public TopRatedMovies2ModelController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/TopRatedMovies2Model
        [HttpGet]
        public ActionResult<IEnumerable<TopRatedMovies2>> Get()
        {
            try
            {
                var topRateds = _context.topRatedMovies2.ToList();
                return Ok(topRateds);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message + "Not Found Result");
            }
        }

        // GET: api/TopRatedMovies2Model/5
        [HttpGet("{id}")]
        public ActionResult<TopRatedMovies2> GetAllLogByID(int id)
        {
            try
            {
                var userLog = _context.topRatedMovies2.Find(id);
                return Ok(userLog);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // PUT: api/TopRatedMovies2Model/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopRatedMovies2Model(int id, TopRatedMovies2 topRatedMovies2Model)
        {
            if (id != topRatedMovies2Model.id)
            {
                return BadRequest();
            }

            _context.Entry(topRatedMovies2Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopRatedMovies2ModelExists(id))
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

        // POST: api/TopRatedMovies2Model
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TopRatedMovies2>> PostTopRatedMovies2Model(TopRatedMovies2 topRatedMovies2Model)
        {
            _context.topRatedMovies2.Add(topRatedMovies2Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopRatedMovies2Model", new { id = topRatedMovies2Model.id }, topRatedMovies2Model);
        }

        // DELETE: api/TopRatedMovies2Model/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopRatedMovies2>> DeleteTopRatedMovies2Model(int id)
        {
            var topRatedMovies2Model = await _context.topRatedMovies2.FindAsync(id);
            if (topRatedMovies2Model == null)
            {
                return NotFound();
            }

            _context.topRatedMovies2.Remove(topRatedMovies2Model);
            await _context.SaveChangesAsync();

            return topRatedMovies2Model;
        }

        private bool TopRatedMovies2ModelExists(int id)
        {
            return _context.topRatedMovies2.Any(e => e.id == id);
        }
    }
}
