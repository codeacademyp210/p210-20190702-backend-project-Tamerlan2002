using FitnessProject.DAL;
using FitnessProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace FitnessProject.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        TemplateContext db = new TemplateContext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Info user)
        {
            
            var userindb = db.Infos.First(x => x.Email == user.Email);
            bool isTrue = Crypto.VerifyHashedPassword(userindb.Password,user.Password);
            if (isTrue)
            {
                FormsAuthentication.SetAuthCookie(userindb.Username,false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Security");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Security");
        }
    }
}