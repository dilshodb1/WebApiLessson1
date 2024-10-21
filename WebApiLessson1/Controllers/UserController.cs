using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLessson1.Models;
using WebApiLessson1.Persistence;
using WebApiLibrary.Models;

namespace WebApiLessson1.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController:ControllerBase
    {
        // KIRISH User login paroli
        private readonly AppDbContext _context;
        public UserController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        [HttpPost]
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

        }
        [HttpGet]
        public List<User> GetAllUser()
        {
            return _context.Users.OrderBy(a=>a.Name).ToList();
        }

        //[HttpPut]
        //public int UpdateUser(User user)
        //{
        //    _context.Users.Update(user);
        //    return _context.SaveChanges();
        //}

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
        //Admin login parol

        [HttpPost("Admin")]
        public void CreateAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }
        [HttpGet("Admin")]
        public List<Admin> GetAdmin()
        {
            return _context.Admins.ToList();
        }
    }
}
