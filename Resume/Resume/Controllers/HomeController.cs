using Microsoft.AspNetCore.Mvc;
using Resume.Models.Contexts;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
