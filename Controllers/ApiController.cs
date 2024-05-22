using Microsoft.AspNetCore.Mvc;
using MSIT158Site.Models;
using Newtonsoft.Json;

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
            System.Threading.Thread.Sleep(10000);
            return Content("世界, 您好!!","text/html", System.Text.Encoding.UTF8);
        }

        //讀出不會重複的城市名
        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }

        //根據城市名讀出不會重複的鄉鎮區
        public IActionResult Districts(string city)
        {          
            var districts = _context.Addresses.Where(a=>a.City == city).Select(a => a.SiteId).Distinct();
            return Json(districts);
        }
        //根據鄉鎮區讀出路名
        public IActionResult Roads(string districts)
        {
            var roads = _context.Addresses.Where(a => a.SiteId == districts).Select(a => a.Road);
            return Json(roads);
        }

        //檢查帳號是否存在
        public IActionResult CheckAccount(string name)
        {
            var member = _context.Members.Any(m => m.Name == name);
          
            return Content(member.ToString(), "text/plain", System.Text.Encoding.UTF8);
        }


        public IActionResult Avatar(int id =1)
        {
            Member? member = _context.Members.Find(id);
            if(member != null)
            {
                byte[] img = member.FileData;
                if(img != null)
                {
                    return File(img, "image/jpeg");
                }

            }
            return NotFound();
        }

        //public IActionResult Register(string userName, string email, int age = 20)
        public IActionResult Register(MemberDTO member)
        {
            if (string.IsNullOrEmpty(member.userName))
            {
                member.userName = "guest";
            }
            return Content($"Hello {member.userName}，{member.Age} 歲了，電子郵件是 {member.Email}", "text/html", System.Text.Encoding.UTF8);
        }
    }
}
