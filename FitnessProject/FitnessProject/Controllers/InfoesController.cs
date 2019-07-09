using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FitnessProject.DAL;
using FitnessProject.Models;

namespace FitnessProject.Controllers
{
    public class InfoesController : Controller
    {
        private TemplateContext db = new TemplateContext();

        // GET: Infoes
        public ActionResult Index()
        {
            return View(db.Infos.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
