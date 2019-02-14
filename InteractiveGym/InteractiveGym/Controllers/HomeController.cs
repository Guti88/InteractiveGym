using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InteractiveGym.Controllers
{
    public class HomeController : Controller
    {
        InteractiveGym.Models.GymDbEntities dB = new Models.GymDbEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
         public ActionResult UsersList()
        {
            var users = (from s in dB.Users
                         orderby s.Id
                         select s).ToList();
            return View(users);
        }
    }
}