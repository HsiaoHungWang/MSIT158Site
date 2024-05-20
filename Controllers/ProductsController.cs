using Microsoft.AspNetCore.Mvc;
using MSIT158Site.Models;

namespace MSIT158Site.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MyDBContext _context;
        public ProductsController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //程式碼
           
            return View();           
            
        }
    }
}
