using Microsoft.AspNetCore.Mvc;
using MSIT158Site.Models;
using System.Diagnostics;

namespace MSIT158Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDBContext _context;

        public HomeController(ILogger<HomeController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {          
            return View(_context.Categories);
        }

        public IActionResult First()
        {
            return View();
        }
        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult JSONTest()
        {
            return View();
        }


        public IActionResult Spots()
        {
            return View();
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