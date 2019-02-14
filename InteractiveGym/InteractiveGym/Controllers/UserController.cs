using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGym.Models;

namespace InteractiveGym.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        // GET: User
        public ActionResult AddOrEdit(int id = 0)
        {
            User userModel = new User();
            return View(userModel);
        }
        [HttpPost]

        public ActionResult AddOrEdit(User userModel)
        {

            using (GymDb models = new GymDb())
            {

                if (models.tabUser.Any(x => x.Login == userModel.Login))
                {

                    ViewBag.DuplicateMessage = "Użytkownik istnieje";
                    return View("AddOrEdit", userModel);

                }

                models.tabUser.Add(userModel);
                models.SaveChanges();


            }
            ModelState.Clear();
            ViewBag.SuccesMessage = "Resjestracja zakończona powodzeniem";
            return View("AddOrEdit", new User());

        }

    }
}