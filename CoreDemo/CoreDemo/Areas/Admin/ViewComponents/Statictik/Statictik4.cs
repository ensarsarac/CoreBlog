using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statictik
{
    public class Statictik4: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            ViewBag.v1 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = c.Admins.Where(x => x.AdminId == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
