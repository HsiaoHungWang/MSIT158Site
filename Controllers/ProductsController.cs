﻿using Microsoft.AspNetCore.Mvc;
using MSIT158Site.Models;

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
