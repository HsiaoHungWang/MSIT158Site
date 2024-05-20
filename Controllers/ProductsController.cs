using Microsoft.AspNetCore.Mvc;

namespace MSIT158Site.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
