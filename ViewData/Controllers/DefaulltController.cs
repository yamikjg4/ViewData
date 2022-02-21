using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewData.Controllers
{
    public class DefaulltController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Yamik Gandhi";
            TempData["fname"] = "Mahesh";
            return View();
        }
        public IActionResult viewuser()
        {
            return View();
        }
    }
}
