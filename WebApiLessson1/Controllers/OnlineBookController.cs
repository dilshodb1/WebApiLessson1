using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiLessson1.Models;
using WebApiLessson1.Persistence;
using WebApiLibrary.Models;

namespace WebApiLibrary.Controllers
{
    [ApiController]
    [Route("OnlineMagazin")]
    public class OnlineBookController
    {
        private readonly AppDbContext ocontext;
        public OnlineBookController(AppDbContext appDbContext)
        {
            ocontext = appDbContext;
        }
        //online dokonga hohlagan odam ozini kitobini qoya oladi
        [HttpPost("history")]
        public void CreateHistory(History history)
        {
            ocontext.Historys.Add(history);
            ocontext.SaveChanges();

        }

        [HttpPut("history")]
        public int UpdateHistory(History history)
        {
            ocontext.Historys.Update(history);
            return ocontext.SaveChanges();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHistory(int id)
        {
            var historydlt = ocontext.Historys.Find(id);
            if (historydlt == null)
            {
                return NotFound(0);
            }

            ocontext.Historys.Remove(historydlt);
            ocontext.SaveChanges();
            return NoContent();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound(int v)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public List<History> GetAllHistory()
        {
            return ocontext.Historys.ToList();
        }
        //kitoblar uchun comment yozsa boladi
        [HttpPost("Comment")]
        public void CreateComment(Comment comment)
        {
            ocontext.Comments.Add(comment);
        }
        [HttpGet("Comment")]
        public List<Comment> GetComments()
        {
            return ocontext.Comments.ToList();
        }

        //post joylashi mumkin
        [HttpPost("Post")]
        public void CreatePost(Post post)
        {
            ocontext.Posts.Add(post);
        }
        [HttpGet("Post")]
        public List <Post> GetPosts()
        {
            return ocontext.Posts.ToList();
        }

        //Topik kitoblar
        [HttpPost("TopBooks")]
        public void CreateTopbooks(Topbook topbook)
        {
            ocontext.Topbooks.Add(topbook);
            ocontext.SaveChanges();
        }
        [HttpGet("TopBooks")]
        public List<Topbook> GetTopbooks()
        {
            return ocontext.Topbooks.ToList();
        }
    }
}
