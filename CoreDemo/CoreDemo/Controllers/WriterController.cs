using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public WriterController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var user = User.Identity.Name;
            ViewBag.v = user;
            var writername = c.Writers.Where(x => x.WriterMail == user).FirstOrDefault();
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        //Bu kaldıralacak kullanılmıyor.
        public PartialViewResult WriterNavbarPartial()
        {
            WriterManager wm = new WriterManager(new EfWriterRepository());
            var user = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == user).Select(y => y.WriterId).FirstOrDefault();

            var values = wm.GetById(writerId);
            return PartialView(values);
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {

            //UserManager userManager = new UserManager(new EfUserRepository());
            var username = User.Identity.Name;
            //var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //var id = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            //var values = userManager.GetById(id);
            var user =await  _userManager.FindByNameAsync(username);
            WriterInfoViewModel model = new WriterInfoViewModel();
            model.namesurname = user.NameSurname;
            model.username = user.UserName;
            model.mail = user.Email;
            ViewBag.v = user;
            return View(model); 
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(WriterInfoViewModel p)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            var userid = c.Users.Where(x => x.UserName == user.UserName).Select(y => y.Id).FirstOrDefault();
            var writer = c.Writers.Where(x => x.WriterId == userid).FirstOrDefault();
            WriterManager wm = new WriterManager(new EfWriterRepository());

            if (p.image != null)
            {
                var extension = Path.GetExtension(p.image.FileName);
                var newImageName = Guid.NewGuid() + extension;

                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.image.CopyTo(stream);
                user.ImageUrl = newImageName;
                writer.WriterImage = newImageName;
                wm.TUpdate(writer);
            }


            user.UserName = p.username;
            user.NameSurname = p.namesurname;
            user.Email = p.mail;
            if(p.password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }

                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Dashboard");
            
        }

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;

                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/WriterImageFiles/",newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);   
                w.WriterImage = newImageName;

            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    
        
        public async Task<IActionResult> WriterLogoutNavbar()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }

    }
}
