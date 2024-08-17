using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;
using Resume.Models.Entities;
using Services;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        private readonly ICryptoService cryptoService;

        public HomeController(DataContext db, ICryptoService cryptoService)
        {
            this.db = db;
            this.cryptoService = cryptoService;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string email,string subject, string message)
        {
            var post= new ContactPost { Name= name, Email=email, Subject= subject, Message= message, CreatedAt=DateTime.Now};
            
            db.ContactPosts.Add(post);
            db.SaveChanges();
            
            return Json(new
            {
                error = false,
                message = "Your message has been received!"
            });
        }
        public IActionResult ResumeMain()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }




        public string Encrypt(string text)
        {
            return cryptoService.Encrypt(text, true);
        }

        public string Decrypt(string text)
        {
            return cryptoService.Decrypt(text);
        }
    }
}
