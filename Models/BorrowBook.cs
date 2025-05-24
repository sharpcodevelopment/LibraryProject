﻿namespace LibraryProject.Models
{
    public class BorrowBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; } = false;
        // Navigation properties
        public  Book Book { get; set; }
        public  User User { get; set; }
    }
}
