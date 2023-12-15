using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statictik
{
    public class Statictik2: ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Count = 0;
            if(c.Blogs.Count() != 0)
            {
                ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogCreateDate).FirstOrDefault();
                ViewBag.Count += 1;

            }
            else
            {
                ViewBag.vNotBlog = "Blog Bulunamadı...";
            }
            return View();
        }
    }
}
