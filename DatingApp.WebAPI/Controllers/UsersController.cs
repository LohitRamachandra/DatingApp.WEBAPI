using DatingApp.WebAPI.Data;
using DatingApp.WebAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        //api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUserById(int id, DataContext _context)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
