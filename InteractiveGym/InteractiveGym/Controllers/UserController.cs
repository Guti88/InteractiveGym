using InteractiveGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InteractiveGym.Controllers
{
    public class UserController : Controller
    {
        InteractiveGym.Models.GymDbEntities dB = new Models.GymDbEntities();
        // GET: User
        public ActionResult Profile(int? id=1)
        {
            Models.UserDimensions item = new Models.UserDimensions();
            var u = from x in dB.Users
                          where x.Id == id
                          select x;
            item.user = u.FirstOrDefault();

            var d = (from x in dB.Dimensions
                     where x.UserID == id
                     select x);
            item.dimensions = d.FirstOrDefault();

            return View(item);
        }
        
        [HttpGet]
        public ActionResult EditUser(int? id)
        {
            var u = (from x in dB.Users
                     where x.Id == id
                     select x);

            var user = u.FirstOrDefault<Models.User>();
            //ViewBag.Users = dB.Users.Select(m => new SelectListItem() { Text = m.Name, Value = m.Id.ToString() });
            return View(user);
        }

        [HttpPost]
        public ActionResult EditUser(User user)
        {
            if (!ModelState.IsValid)
                return View();
            SaveUser(user);
            return RedirectToAction("Profile");
        }

        private void SaveUser(Models.User data)
        {
            Models.User inDb = dB.Users.Find(data.Id);
            if(inDb != null)
            {
                inDb.Name = data.Name;
                inDb.Surname = data.Surname;
                inDb.Hight = data.Hight;
                inDb.Weight = data.Weight;
            }
        }
        
            [HttpGet]
        public ActionResult EditDim(int? id)
        {
            var d = (from x in dB.Dimensions
                     where x.UserID == id
                     select x);
            var dimension = d.FirstOrDefault<Models.Dimension>();

            return View(dimension);
        }
    }
}