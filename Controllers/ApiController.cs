using Microsoft.AspNetCore.Mvc;
using MSIT158Site.Models;

namespace MSIT158Site.Controllers
{
    public class ApiController : Controller
    {
     private readonly MyDBContext _context;
        public ApiController(MyDBContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            return Content("<h2>世界, 您好!!</h2>","text/html", System.Text.Encoding.UTF8);
        }

        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
    }
}
