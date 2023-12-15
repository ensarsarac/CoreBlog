using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotification: ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository()); 
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList().Where(x=>x.NotificationStatus==true).OrderByDescending(x=>x.NotificationDate).ToList();
            ViewBag.v = values.Count();
            return View(values);
        }
    }
}
