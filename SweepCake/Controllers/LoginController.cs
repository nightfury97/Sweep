using Shop_data.Control;
using SweepCake.Common;
using SweepCake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace SweepCake.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Login(LoginModel model )
        {
            if (ModelState.IsValid)
            {
                var dao = new LoginControl();
                var kq = dao.login(model.ID,Encryptor.MD5Hash(model.Pass));
                if (kq!=0)
                {
                    var user = dao.GetByID(model.ID);
                    var userSession = new UserLogin();
                    userSession.UserID = user.ID;
                    userSession.IdRule = Convert.ToInt32(user.ID_Rule);

                    Session.Add(CommonConstant.USER_SESSION, userSession);
                    return RedirectToAction("checkout", "product");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorect");
                }
            }
            return View();
        }
    }
}  