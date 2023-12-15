using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        Context c = new Context();
        public IActionResult CategoryChart()
        {
            var categories = c.Categories.ToList();
           
            return Json(new { jsonList = categories });
        }
    }
}
