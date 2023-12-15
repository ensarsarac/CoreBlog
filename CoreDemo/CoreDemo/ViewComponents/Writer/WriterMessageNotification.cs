using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var userid = c.Users.Where(x => x.UserName == username).Select(y => y.Id).FirstOrDefault();
            var values = mm.GetAllMessage2WithNamee(userid);
            return View(values);
        }
    }
}
