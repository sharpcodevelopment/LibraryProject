
using LibraryProject.Context;
using LibraryProject.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
namespace LibraryProject.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly LibraryDbContext _context;

        public CategoriesController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category); // ✅ Form hatalıysa, tekrar Create view'ını göster
        }


        public IActionResult TopCategory()
        {
            var TopCategories = _context.Categories.Where(t => t.ParentCategory == 0).ToList();
            return Json(new { status = true, data = TopCategories });
        }
    }
}