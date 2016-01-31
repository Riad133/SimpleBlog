using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModels;


namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {


            return View(new AuthLogin()
            {
                
            }
                );

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }


        [HttpPost]

        public ActionResult Login (AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);
            
            FormsAuthentication.SetAuthCookie(form.UserName,true);


            return Content("Hi  there "+form.UserName);
        }

    }
}