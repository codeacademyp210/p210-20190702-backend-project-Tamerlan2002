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
    public class CourseSchedulesController : Controller
    {
        private TemplateContext db = new TemplateContext();

        
        // GET: CourseSchedules
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: CourseSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedule courseSchedule = db.CourseSchedules.Find(id);
            if (courseSchedule == null)
            {
                return HttpNotFound();
            }
            return View(courseSchedule);
        }

        // GET: CourseSchedules/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name");
            ViewBag.DayOfWeekId = new SelectList(db.DaysOfWeeks, "Id", "Name");
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name");
            ViewBag.TrainerId = new SelectList(db.Trainers, "Id", "Name");
            var courseSchedules = db.CourseSchedules.Include(c => c.Course).Include(c => c.DayOfWeek).Include(c => c.Room).Include(c => c.Trainer).ToList();
            ViewBag.AllCourse = courseSchedules;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StartTime,FinishTime,DayOfWeekId,RoomId,TrainerId,CourseId,Description")] CourseSchedule courseSchedule)
        {
            if (ModelState.IsValid)
            {
                db.CourseSchedules.Add(courseSchedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseSchedule.CourseId);
            ViewBag.DayOfWeekId = new SelectList(db.DaysOfWeeks, "Id", "Name", courseSchedule.DayOfWeekId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", courseSchedule.RoomId);
            ViewBag.TrainerId = new SelectList(db.Trainers, "Id", "Name", courseSchedule.TrainerId);
            return View();
        }

        // GET: CourseSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedule courseSchedule = db.CourseSchedules.Find(id);
            if (courseSchedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseSchedule.CourseId);
            ViewBag.DayOfWeekId = new SelectList(db.DaysOfWeeks, "Id", "Name", courseSchedule.DayOfWeekId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", courseSchedule.RoomId);
            ViewBag.TrainerId = new SelectList(db.Trainers, "Id", "Name", courseSchedule.TrainerId);
            return View(courseSchedule);
        }

        // POST: CourseSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StartTime,FinishTime,DayOfWeekId,RoomId,TrainerId,CourseId,Description")] CourseSchedule courseSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseSchedule.CourseId);
            ViewBag.DayOfWeekId = new SelectList(db.DaysOfWeeks, "Id", "Name", courseSchedule.DayOfWeekId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", courseSchedule.RoomId);
            ViewBag.TrainerId = new SelectList(db.Trainers, "Id", "Name", courseSchedule.TrainerId);
            return View(courseSchedule);
        }

        // GET: CourseSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedule courseSchedule = db.CourseSchedules.Find(id);
            if (courseSchedule == null)
            {
                return HttpNotFound();
            }
            return View(courseSchedule);
        }

        // POST: CourseSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseSchedule courseSchedule = db.CourseSchedules.Find(id);
            db.CourseSchedules.Remove(courseSchedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Rooms()
        {
            return View();
        }
        public ActionResult Trainers()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
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
