using BlogApiDemo.DataAccessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var values = nm.GetList().OrderByDescending(x=>x.NotificationDate).ToList();
            return View(values);
        }

        public IActionResult NotificationDetails(int id)
        {
            var values = nm.GetById(id);
            values.NotificationStatus = false;
            nm.TUpdate(values);
            return View(values);
        }
    }
}
