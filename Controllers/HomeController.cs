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
            // Burada formdan gelen verileri i�leyebilirsiniz.
            // �rne�in, veritaban�na kaydedebilir veya email ile g�nderebilirsiniz.

            ViewBag.Message = "Mesaj�n�z g�nderildi. Te�ekk�rler!";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
