using BPC.Data;
using BPC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BPC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var cheapestBooks = context.Books.OrderBy(x => x.Price).Take(3).ToList();
            _logger.LogError(cheapestBooks.Count() + "kitap getirildi.");
            var db = new ApplicationDbContext();
            var Books = db.Books.Where(x => x.Name).OrderbyDescending(a => a.Price);
            return View(cheapestBooks);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}