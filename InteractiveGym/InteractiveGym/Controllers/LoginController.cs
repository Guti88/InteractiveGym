using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheGym.Models;

namespace InteractiveGym.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(TheGym.Models.User userModel)
        {
            using (GymDb models = new GymDb())
            {
                var userDetails = models.tabUser.Where(x => x.Login == userModel.Login && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {

                    return View("Index", userModel);
                }
                else
                {
                    Session["userID"] = userDetails.Id;
                    Session["userName"] = userDetails.Login;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }


    }
}