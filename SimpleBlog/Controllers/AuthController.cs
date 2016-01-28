using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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



        [HttpPost]

        public ActionResult Login (AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);
            if (form.UserName!="Riad" )
            {
                ModelState.AddModelError("UserName","User name or password not correct");
                return View(form);
            }
            return Content("Hi  there "+form.UserName);
        }

    }
}