using WebApiLessson1.Models;

namespace WebApiLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public virtual Book book { get; set; }
    }
}
