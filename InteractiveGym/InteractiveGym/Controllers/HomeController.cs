using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheGym.Models;

namespace InteractiveGym.Controllers
{
    public class HomeController : Controller
    {
        GymDb db = new GymDb();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
    }
}