using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Shop_data.FrameWork;

namespace SweepCake.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult register(Customer us)
        {

            return View();
        }
        public ActionResult register1(Customer us)
        {

            return View();
        }
    }
}