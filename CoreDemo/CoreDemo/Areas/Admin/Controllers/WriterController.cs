using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller

    {
        private readonly UserManager<AppUser> _userManager;
        Context c = new Context();
        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> WriterList()
        {
            var userList = c.Users.ToList();
            var jsonWriter = JsonConvert.SerializeObject(userList);
            return Json(jsonWriter);
        }


        public IActionResult GetWriterById(int writerid)
        {

            //var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var userid = c.Users.Where(x => x.Id == writerid).FirstOrDefault();
            var jsonWriter = JsonConvert.SerializeObject(userid);
            return Json(jsonWriter);

        }

        public IActionResult RemoveWriter(int writerid)
        {
            //var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var userid = c.Users.Where(x => x.Id == writerid).FirstOrDefault();
            var jsonWriter = c.Users.Remove(userid);
            c.SaveChanges();
            return Json(jsonWriter);

        }

        [HttpPost]
        public IActionResult UpdateWriter(WriterClass w)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == w.Id);
            findWriter.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);

        }


        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name="Ayşe"
            },

            new WriterClass
            {
                Id = 2,
                Name="Ahmet"
            },

            new WriterClass
            {
                Id = 3,
                Name="Buse"
            }
        };

       
    }
}
