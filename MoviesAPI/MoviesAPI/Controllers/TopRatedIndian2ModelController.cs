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
    public class TopRatedIndian2ModelController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public TopRatedIndian2ModelController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/TopRatedIndian2Model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopRatedIndian2>>> GetTopRatedIndian2Model()
        {
            return await _context.topRatedIndian2.ToListAsync();
        }

        // GET: api/TopRatedIndian2Model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TopRatedIndian2>> GetTopRatedIndian2Model(int id)
        {
            var topRatedIndian2Model = await _context.topRatedIndian2.FindAsync(id);

            if (topRatedIndian2Model == null)
            {
                return NotFound();
            }

            return topRatedIndian2Model;
        }

        // PUT: api/TopRatedIndian2Model/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopRatedIndian2Model(int id, TopRatedIndian2 topRatedIndian2Model)
        {
            if (id != topRatedIndian2Model.id)
            {
                return BadRequest();
            }

            _context.Entry(topRatedIndian2Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopRatedIndian2ModelExists(id))
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

        // POST: api/TopRatedIndian2Model
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TopRatedIndian2>> PostTopRatedIndian2Model(TopRatedIndian2 topRatedIndian2Model)
        {
            _context.topRatedIndian2.Add(topRatedIndian2Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopRatedIndian2Model", new { id = topRatedIndian2Model.id }, topRatedIndian2Model);
        }

        // DELETE: api/TopRatedIndian2Model/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopRatedIndian2>> DeleteTopRatedIndian2Model(int id)
        {
            var topRatedIndian2Model = await _context.topRatedIndian2.FindAsync(id);
            if (topRatedIndian2Model == null)
            {
                return NotFound();
            }

            _context.topRatedIndian2.Remove(topRatedIndian2Model);
            await _context.SaveChangesAsync();

            return topRatedIndian2Model;
        }

        private bool TopRatedIndian2ModelExists(int id)
        {
            return _context.topRatedIndian2.Any(e => e.id == id);
        }
    }
}
