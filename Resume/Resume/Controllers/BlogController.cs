using Microsoft.AspNetCore.Mvc;
using Resume.Models.Contexts;
using Resume.Models.Entities;

namespace Resume.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataContext db;


        public BlogController(DataContext db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(string title, string body, string imagePath, int createdBy)
        {
            var post = new BlogPost
            {
                Title = title,
                Body = body,
                ImagePath = imagePath,
                CreatedBy = createdBy,
                CreatedAt = DateTime.Now
            };

            db.BlogPosts.Add(post);
            db.SaveChanges();

            return Json(new
            {
                error = false,
                message = "Post created successfully."
            });
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}
