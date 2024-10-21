using WebApiLibrary.Models;

namespace WebApiLessson1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public virtual Category category { get; set; }
        public virtual Topbook topBook { get; set; }
    }
}
