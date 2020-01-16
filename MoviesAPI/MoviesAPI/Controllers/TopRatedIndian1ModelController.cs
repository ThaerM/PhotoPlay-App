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
    public class TopRatedIndian1ModelController : ControllerBase
    {
        private readonly MoviesDBContext _context;

        public TopRatedIndian1ModelController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/TopRatedIndian1Model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopRatedIndian1>>> GetTopRatedIndian1Model()
        {
            try
            {
                var topRateds = _context.topRatedIndian1.ToList();
                return Ok(topRateds);
            }
            catch (Exception ex)
            {
                return NotFound(ex + "Not Found Result");
            }
            return await _context.topRatedIndian1.ToListAsync();
        }

        // GET: api/TopRatedIndian1Model/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TopRatedIndian1>> GetTopRatedIndian1Model(int id)
        {
            var topRatedIndian1Model = await _context.topRatedIndian1.FindAsync(id);

            if (topRatedIndian1Model == null)
            {
                return NotFound();
            }

            return topRatedIndian1Model;
        }

        // PUT: api/TopRatedIndian1Model/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopRatedIndian1Model(int id, TopRatedIndian1 topRatedIndian1Model)
        {
            if (id != topRatedIndian1Model.id)
            {
                return BadRequest();
            }

            _context.Entry(topRatedIndian1Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TopRatedIndian1ModelExists(id))
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

        // POST: api/TopRatedIndian1Model
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TopRatedIndian1>> PostTopRatedIndian1Model(TopRatedIndian1 topRatedIndian1Model)
        {
            _context.topRatedIndian1.Add(topRatedIndian1Model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopRatedIndian1Model", new { id = topRatedIndian1Model.id }, topRatedIndian1Model);
        }

        // DELETE: api/TopRatedIndian1Model/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TopRatedIndian1>> DeleteTopRatedIndian1Model(int id)
        {
            var topRatedIndian1Model = await _context.topRatedIndian1.FindAsync(id);
            if (topRatedIndian1Model == null)
            {
                return NotFound();
            }

            _context.topRatedIndian1.Remove(topRatedIndian1Model);
            await _context.SaveChangesAsync();

            return topRatedIndian1Model;
        }

        private bool TopRatedIndian1ModelExists(int id)
        {
            return _context.topRatedIndian1.Any(e => e.id == id);
        }
    }
}
