using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult ExportStaticExcelBlogList()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            using (var workbook= new XLWorkbook())
            {
                var values = bm.GetList();
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Adı";
                int BlogRowCount = 2;
                foreach (var item in values)
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.BlogId;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogTitle;
                    BlogRowCount++;
                }
                using(var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnc.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }

        public IActionResult AllBlogs()
        {
            BlogManager bm = new BlogManager(new EfBlogRepository());
            var values = bm.BlogIncludeWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            var values = bm.AdminBlogDetails(id);
            return View(values);
        }

        public IActionResult BlogComments()
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            var values = cm.AdminCommentWithUser().OrderByDescending(x=>x.CommentDate).ToList();
            return View(values);
        }

        public IActionResult RemoveComment(int id)
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            var comment = cm.GetById(id);
            cm.TDelete(comment);

            return RedirectToAction("BlogComments", "Blog");
        }

        [HttpGet]
        public IActionResult CommentUpdate(int id)
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());
            var comment = cm.GetById(id);
            return View(comment);
        }

        [HttpPost]
        public IActionResult CommentUpdate(Comment p)
        {
            CommentManager cm = new CommentManager(new EfCommentRepository());

            var comment = cm.GetById(p.CommentId);
           
            
                comment.CommentTitle = p.CommentTitle;
                comment.CommentContent = p.CommentContent;
            
            
            cm.TUpdate(comment);
            return RedirectToAction("BlogComments", "Blog");
        }

    }
}
