
using LibraryProject.Context;
using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryProject.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            var categories = _context.Categories.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
        

            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}