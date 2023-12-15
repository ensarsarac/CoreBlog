using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();

        public WriterAboutOnDashboard(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var about = c.Writers.Where(x => x.WriterMail == user.Email).Select(y => y.WriterAbout).FirstOrDefault();
            ViewBag.about = about;         
            return View(user);
        }
    }
}
