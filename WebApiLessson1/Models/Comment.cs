using WebApiLessson1.Models;

namespace WebApiLibrary.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
