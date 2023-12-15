using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using CoreDemo.Models;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        DashboardList list = new DashboardList();
        Context c = new Context();
        public IActionResult Index()
        {
            var user = c.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            WriterManager wm = new WriterManager(new EfWriterRepository());
            ViewBag.onlineUser = wm.GetById(user.Id);
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Blogs.Where(x=>x.WriterId==user.Id).Count();
            ViewBag.v3 = c.Categories.Count();
            var values = bm.BlogIncludeWithCategory().Where(x=>x.WriterId==user.Id).OrderByDescending(x => x.BlogCreateDate).Take(4);
            var comments = cm.getList();
            return View(new DashboardList
            {
                blogList = values,
                commentList = comments,
            });
        }
    }
}
