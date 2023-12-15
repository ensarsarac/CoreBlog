using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]

    public class RegisterUserController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            WriterManager wm = new WriterManager(new EfWriterRepository());
            Writer w = new Writer();



            if (ModelState.IsValid)
            {
                w.WriterName = p.NameSurname;
                w.WriterAbout = "Hakkında";
                w.WriterImage = "Image";
                w.WriterMail = p.Mail;
                w.WriterPassword = "000";
                w.WriterStatus = true;

                wm.TAdd(w);

                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.Username,
                    NameSurname = p.NameSurname,
                    ImageUrl = "default-image.jpg",
                };

                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }


    }
}
