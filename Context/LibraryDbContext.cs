using LibraryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Context
{
    public class LibraryDbContext:DbContext
    {
        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SRGN-ALDG1;Database=LibraryDb;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }

    }
}
