using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly MoviesDBContext _context;
        public ProfileController(MoviesDBContext context)
        {
            _context = context;
        }

        // GET: api/Profile/5
        [HttpGet("{email}/{password}")]
        public ActionResult<Profile> GetProfile(string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                var user = _context.profile.Where(x => x.email == email && x.password == password).FirstOrDefault();
                if (user != null)
                    return Ok(new
                    {
                        user.email,
                        user.first_name,
                        user.last_name,
                        user.id
                    });
                else
                    return NotFound("The User Not found");
            }
            else
            {
                return NotFound("The user not found");
            }
        }

        // POST: api/Profile
        [HttpPost]
        public ActionResult Post(Profile user)
        {
            try
            {
                if (_context.profile.Contains(user))
                {
                    _context.profile.Update(user);
                }
                else
                {
                    user.id = null;
                    _context.profile.Add(user);
                }
                _context.SaveChanges();
                return Ok(user);
            }
            catch(Exception ex)
            {

                return NotFound("We have some issue"+ex.Message);
            }
        }
    }
}
