using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class Category : Controller
    {
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        BlogManager categoryBlog = new BlogManager(new EfBlogRepository());
        CategoryManager category= new CategoryManager(new EfCategoryRepository());


        public IActionResult Index(int id)
        {
            var blogs = categoryBlog.GetList().Where(m=>m.CategoryId == id);
            ViewBag.CategoryTitle = category.GetList().FirstOrDefault(m=>m.CategoryId == id);
            return View(blogs);
        }
    }
}
