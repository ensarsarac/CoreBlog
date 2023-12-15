using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog: ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        Context c = new Context();


        public IViewComponentResult Invoke(int id)
        {

            var comments = cm.CommentWithUser(id);
           
            return View(comments);
        }
    }
}
