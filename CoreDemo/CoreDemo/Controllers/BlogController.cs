using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreDemo.Areas.Admin.Models;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CommentManager cm = new CommentManager(new EfCommentRepository());
        Context c = new Context();

        EfBlogRepository ebp = new EfBlogRepository();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var comments = cm.getList();
            ViewBag.CommentOfBlog = comments;

            var values = bm.BlogIncludeWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var blogs = ebp.GetById(id);
            var sonblogs = bm.GetList().OrderByDescending(o => o.BlogCreateDate).FirstOrDefault();
            return View(new BlogDetailsViewModel { 
                Blog = blogs,
                SonBlog = sonblogs
            }); 
        }

        public IActionResult BlogListByWriter()
        {
            var user = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();
            var values = bm.WriterBlogWithCategory(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            //IEnumerable<SelectListItem> categoryValues = (from x in cm.GetList()
            //                                       select new SelectListItem
            //                                       {
            //                                           Text=x.CategoryName,
            //                                           Value = x.CategoryId.ToString(),
            //                                       }).ToList();

            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            var categoryValues = new SelectList(cm.GetList(), "CategoryId", "CategoryName");
            ViewBag.categoryListAll = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            var user = c.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = user.Id;                
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            var categoryValues = new SelectList(cm.GetList(), "CategoryId", "CategoryName");
            ViewBag.categoryListAll = categoryValues;


            return View(p);
        }


        public IActionResult BlogRemove(int id)
        {
            var blog = bm.GetById(id);
            bm.TDelete(blog);
            return RedirectToAction("BlogListByWriter","Blog");
        }


        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            var categoryValues = new SelectList(cm.GetList(), "CategoryId", "CategoryName");
            ViewBag.categoryListAll = categoryValues;
            var blog = bm.GetById(id);
            return View(blog);
        }

        [HttpPost] 
        public IActionResult BlogUpdate(Blog b)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(b);
            var user = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == user).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();


            if (results.IsValid)
            {
                b.BlogStatus = true;
                b.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.WriterId = writerId;

                bm.TUpdate(b);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            var categoryValues = new SelectList(cm.GetList(), "CategoryId", "CategoryName");
            ViewBag.categoryListAll = categoryValues;
            return RedirectToAction("BlogListByWriter");
        }

    }
}
