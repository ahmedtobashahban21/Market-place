using Microsoft.AspNetCore.Mvc;
using SouqMarket.Models;
using System.Diagnostics;

namespace SouqMarket.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            SouqMarketContext _context = new SouqMarketContext();   
            var cats = _context.Categories.ToList();
            return View(cats);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Categories()
        {
            SouqMarketContext _context = new SouqMarketContext();
            var cats = _context.Categories.ToList();
            return View(cats);
        }
        public IActionResult About()
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
