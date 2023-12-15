using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class HomeController : BlogController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
