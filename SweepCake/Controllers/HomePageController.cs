using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweepCake.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult myaccount()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
    }
}