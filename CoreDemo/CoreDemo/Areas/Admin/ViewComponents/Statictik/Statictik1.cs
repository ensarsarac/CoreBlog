using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statictik
{
    public class Statictik1: ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string api = "1e4d66de593fe791493f6744e4538ffd";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&appid="+api;
            XDocument document = XDocument.Load(connection);

            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
