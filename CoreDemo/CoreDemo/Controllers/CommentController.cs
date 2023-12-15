using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager bm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCommentView(Comment comment)
        {
            Context c = new Context();
            var user = User.Identity.Name;
            var id = c.Users.Where(x => x.UserName == user).Select(y => y.Id).FirstOrDefault();
            comment.BlogId = comment.BlogId;
            comment.CommentStatus = true;
            comment.CommentDate = DateTime.Now;
            comment.AppUserId = id;
            bm.AddComment(comment);
            return RedirectToAction("BlogDetails","Blog", new {id =comment.BlogId });
        }

       

    }
}
