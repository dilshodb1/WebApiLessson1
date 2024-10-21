using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLessson1.Models;
using WebApiLessson1.Persistence;
using WebApiLibrary.Models;

namespace WebApiLibrary.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        //kutubxonaga kitoplarni registratsiya qilish sotish 
        private readonly AppDbContext bcontext;
        public BookController(AppDbContext appDbContext)
        {
            bcontext = appDbContext;
        }
        [HttpPost("Category")]
        public void CreateCategory(Category category)
        {
            bcontext.Categories.Add(category);
            bcontext.SaveChanges();
        }
        [HttpGet("Category")]
        public List<Category> GetCategories()
        {
            return bcontext.Categories.ToList();
        }


        [HttpPost]
        public void CreateBook(Book book)
        {
            bcontext.Books.Add(book);
            bcontext.SaveChanges();

        }
        [HttpPut]
        public int UpdateBook(Book book)
        {
            bcontext.Books.Update(book);
            return bcontext.SaveChanges();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var bookdlt = bcontext.Books.Find(id);
            if (bookdlt == null)
            {
                return NotFound();
            }

            bcontext.Books.Remove(bookdlt);
            bcontext.SaveChanges();
            return NoContent();
        }
        [HttpGet]
        public List<Book> GetAllBook()
        {
            return bcontext.Books.ToList();
        }

        [HttpPost("Order")]
        public void CreateOrder(Order order)
        {
            bcontext.Orders.Add(order);
            bcontext.SaveChanges();
        }
        [HttpGet("Order")]
        public List<Order> GetAllOrders()
        {
            return bcontext.Orders.ToList();
        }

        //topik kitoblar
        [HttpPost("TopBooks")]
        public void CreateTopbooks(Topbook topbook)
        {
            bcontext.Topbooks.Add(topbook);
            bcontext.SaveChanges();
        }
        [HttpGet("TopBooks")]
        public List<Topbook> GetTopbooks()
        {
            return bcontext.Topbooks.ToList();
        }
    }
}
