using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheGym.Models;

namespace InteractiveGym.Controllers
{
    public class ProfileController : Controller
    {
        GymDb db = new GymDb();

        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile(int? id)
        {
            if (id == null)
            {
                return View(new HttpStatusCodeResult(HttpStatusCode.BadRequest));
            }
            User user = db.tabUser.Find(id);
            if (user == null)
                return View(HttpNotFound());
            ViewBag.Profiles=db.tabUser.Select(m => new SelectListItem() { Text = m.Name, Value = m.Id.ToString() });
            return View(user);
        }

        [HttpPost]
        public ActionResult Profile(User user)
        {
            if (!ModelState.IsValid)
                return View();
            SaveProfile(user);
            return RedirectToAction("Index");
        }

        private void SaveProfile(TheGym.Models.User data)
        {
            if (data.Id == 0)
            {//zapis nowego
                db.tabUser.Add(data);
            }
            else
            {//zapis zmian
                TheGym.Models.User inBase = db.tabUser.Find(data.Id);
                if (inBase != null)
                {
                    inBase.Name = data.Name;
                    inBase.Id = data.Id;
                    inBase.Surname = data.Surname;
                    inBase.Weight = data.Weight;
                    inBase.Hight = data.Hight;
                }
            }
            db.SaveChanges();
        }
    }
}