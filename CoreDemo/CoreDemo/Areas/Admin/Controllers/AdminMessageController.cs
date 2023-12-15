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

namespace CoreDemo.Areas.Admin.Controllers
{
    public class AdminMessageController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public AdminMessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("Admin")]

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.GetAllMessage2WithNamee2Manager(user.Id);
            return View(values);
        }
        [Area("Admin")]

        public async Task<IActionResult> Sendbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.SenderMessageWithIdManager(user.Id);
            return View(values);
        }

        [Area("Admin")]
        [HttpGet]

        public IActionResult SendMail()
        {

            return View();
        }
        [Area("Admin")]

        [HttpPost]
        public async Task<IActionResult> SendMail(string ReceiverEmail, string Subject, string Details)
        {
            Context c = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverUser = c.Users.Where(x => x.Email == ReceiverEmail).Select(y => y.Id).FirstOrDefault();
            Message2 m = new Message2();
            m.SenderId = user.Id;
            m.ReceiverId = receiverUser;
            m.MessageSubject = Subject;
            m.MessageDetails = Details;
            m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            m.MessageStatus = true;
            mm.TAdd(m);

            return RedirectToAction("Sendbox");
        }

       

    }
}
