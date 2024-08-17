﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();  
        }
    }
}
