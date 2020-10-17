using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sokhan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult doLogin()
        {
            return RedirectToAction("Index", "Teachers");
        }
    }
}
