using Microsoft.AspNetCore.Mvc;
using MyPortfolioBlog.Data;
using MyPortfolioBlog.Models;
using System.Linq;
using System.Collections.Generic;

namespace MyPortfolioBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.BlogPosts.ToList();
            return View(posts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            var posts = _context.BlogPosts.ToList();
            return View(posts);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            // Burada formdan gelen verileri iþleyebilirsiniz.
            // Örneðin, veritabanýna kaydedebilir veya email ile gönderebilirsiniz.

            ViewBag.Message = "Mesajýnýz gönderildi. Teþekkürler!";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
