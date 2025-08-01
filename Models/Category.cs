namespace LibraryProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        public int ParentCategory { get; set; }

    }
}
