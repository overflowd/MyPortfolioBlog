using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyPortfolioBlog.Data;
using MyPortfolioBlog.Models;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MyPortfolioBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var posts = _context.BlogPosts.ToList();
            ViewData["Title"] = "Ana Sayfa";
            return View(posts);
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Hakkımda";
            return View();
        }

        public IActionResult Blog()
        {
            var posts = _context.BlogPosts.ToList();
            ViewData["Title"] = "Blog";
            return View(posts);
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "İletişim";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string message)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings");
                var fromAddress = new MailAddress(smtpSettings["SenderEmail"], smtpSettings["SenderName"]);
                var toAddress = new MailAddress("atalaycelik4@gmail.com", "Atalay Çelik");
                string fromPassword = smtpSettings["Password"];
                const string subject = "AtalayÇelikBlog";
                string body = $"Ad-Soyad: {name}\n\nMesaj: {message}";

                var smtp = new SmtpClient
                {
                    Host = smtpSettings["Server"],
                    Port = int.Parse(smtpSettings["Port"]),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var mailMessage = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mailMessage);
                }
                ViewBag.Message = "Mesajınız gönderildi. Teşekkürler!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Mesaj gönderilirken bir hata oluştu: {ex.Message}";
            }

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}