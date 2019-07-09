using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessProject.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserList()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult Payments()
        {
            return View();
        }
    }
}