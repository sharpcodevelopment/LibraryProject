using System.Net;
using LibraryProject.Context;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Controllers
{
       public class UsersController : Controller
    {
        private readonly LibraryDbContext _context;

        public UsersController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (_context.Users.Any(u=> u.Name == user.Name))
            {
                ModelState.AddModelError("Name", "User with this name already exists.");
                return View("Index");
               
            }
           

            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
