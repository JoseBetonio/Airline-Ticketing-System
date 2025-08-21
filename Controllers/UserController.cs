using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using TicketingAPI.Data;
using TicketingAPI.Models;

namespace TicketingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> PostUser(UserModel User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsers), new { id = User.Id }, User);
        }
    }
}