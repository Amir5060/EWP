using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EWP.Models;

namespace EWP.Controllers
{
    [CheckAuthorize(Roles = "Admin")]
    public class WorkoutMusclesController : Controller
    {
        private EWPEntities db = new EWPEntities();

        // GET: WorkoutMuscles
        public ActionResult Index()
        {
            var workoutMuscles = db.WorkoutMuscles.Include(w => w.Muscle).Include(w => w.Workout);
            return View(workoutMuscles.ToList());
        }

        // GET: WorkoutMuscles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutMuscle workoutMuscle = db.WorkoutMuscles.Find(id);
            if (workoutMuscle == null)
            {
                return HttpNotFound();
            }
            return View(workoutMuscle);
        }

        // GET: WorkoutMuscles/Create
        public ActionResult Create()
        {
            ViewBag.MuscleID = new SelectList(db.Muscles, "MuscleID", "MuscleID");
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "Name");
            return View();
        }

        // POST: WorkoutMuscles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkoutMuscleID,WorkoutID,MuscleID,PrimMover,Synergist,Stabilizer,Lengthening")] WorkoutMuscle workoutMuscle)
        {
            if (ModelState.IsValid)
            {
                db.WorkoutMuscles.Add(workoutMuscle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MuscleID = new SelectList(db.Muscles, "MuscleID", "MuscleID", workoutMuscle.MuscleID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "Name", workoutMuscle.WorkoutID);
            return View(workoutMuscle);
        }

        // GET: WorkoutMuscles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutMuscle workoutMuscle = db.WorkoutMuscles.Find(id);
            if (workoutMuscle == null)
            {
                return HttpNotFound();
            }
            ViewBag.MuscleID = new SelectList(db.Muscles, "MuscleID", "MuscleID", workoutMuscle.MuscleID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "Name", workoutMuscle.WorkoutID);
            return View(workoutMuscle);
        }

        // POST: WorkoutMuscles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkoutMuscleID,WorkoutID,MuscleID,PrimMover,Synergist,Stabilizer,Lengthening")] WorkoutMuscle workoutMuscle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workoutMuscle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MuscleID = new SelectList(db.Muscles, "MuscleID", "MuscleID", workoutMuscle.MuscleID);
            ViewBag.WorkoutID = new SelectList(db.Workouts, "WorkoutID", "Name", workoutMuscle.WorkoutID);
            return View(workoutMuscle);
        }

        // GET: WorkoutMuscles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutMuscle workoutMuscle = db.WorkoutMuscles.Find(id);
            if (workoutMuscle == null)
            {
                return HttpNotFound();
            }
            return View(workoutMuscle);
        }

        // POST: WorkoutMuscles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkoutMuscle workoutMuscle = db.WorkoutMuscles.Find(id);
            db.WorkoutMuscles.Remove(workoutMuscle);
            db.SaveChanges();
            return RedirectToAction("Index");
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
