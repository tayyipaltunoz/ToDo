using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        private Context context = new Context();
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(User user)
        {

            var bilgiler = context.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.UserName, false);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return View();
            }


        }
    }
}