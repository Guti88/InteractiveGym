using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InteractiveGym.Controllers
{
    public class DimensionsController : Controller
    {
        // GET: Dimensions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dimensions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dimensions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dimensions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dimensions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dimensions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dimensions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dimensions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
