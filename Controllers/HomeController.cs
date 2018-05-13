using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManyToManyExample.Models;

namespace ManyToManyExample.Controllers
{
    public class HomeController : Controller
    {
        private SecurityContext db = new SecurityContext();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
        public ActionResult Security()
        {
            return View(db.SecurityPolicy.ToList());
        }
        public ActionResult UserInfo(int id=0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
        public ActionResult SecurityInfo(int id=0)
        {
            SecurityPolicy security = db.SecurityPolicy.Find(id);
            if (security == null)
            {
                return HttpNotFound();
            }
            return View(security);
        }
    }
}