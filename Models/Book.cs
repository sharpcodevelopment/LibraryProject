namespace LibraryProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }
        public string Genre { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public bool IsAvailable { get; set; } = true;
        
    }
}
