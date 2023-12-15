using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());


        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> IncomingMessages()
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = mm.GetAllMessage2WithNamee2Manager(user.Id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var message = mm.GetMessageIncludeUserWithIdManager(id);
            message.MessageStatus = false;
            mm.TUpdate(message);
            return View(message);
        }


        public IActionResult DeleteMessage(int id)
        {
            var message = mm.GetById(id);
            mm.TDelete(message);
            return RedirectToAction("IncomingMessages","Message");
        }
        public IActionResult DeleteMessage2(int id)
        {
            var message = mm.GetById(id);
            mm.TDelete(message);
            return RedirectToAction("SendMessages", "Message");
        }

        public async Task<IActionResult> SendMessages()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messages = mm.SenderMessageWithIdManager(user.Id);
            return View(messages);
        }

        [HttpGet]
        public IActionResult MessageAdd()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MessageAdd(MessageAddViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiveuser =await _userManager.FindByEmailAsync(p.ToUser);

            var message = new Message2();
            message.SenderId = user.Id;
            message.ReceiverId = receiveuser.Id;
            message.MessageSubject = p.Subject;
            message.MessageDetails = p.Details;
            message.MessageDate = DateTime.Now;
            message.MessageStatus = true;

            mm.TAdd(message);
            return RedirectToAction("SendMessages","Message");
        }

    }
}
