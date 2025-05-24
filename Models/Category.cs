namespace LibraryProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategory { get; set; }

    }
}
