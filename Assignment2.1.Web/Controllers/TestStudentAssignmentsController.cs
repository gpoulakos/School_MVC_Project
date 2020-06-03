using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2._1.Database;
using Assignment2._1.Entities;

namespace Assignment2._1.Web.Controllers
{
    public class TestStudentAssignmentsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: TestStudentAssignments
        public ActionResult Index()
        {
            var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Student);
            return View(studentAssignments.ToList());
        }

        // GET: TestStudentAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignment);
        }

        // GET: TestStudentAssignments/Create
        public ActionResult Create()
        {
            ViewBag.AssignmentId = new SelectList(db.Assignments, "AssignmentId", "Title");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FirstName");
            return View();
        }

        // POST: TestStudentAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,AssignmentId,CodeMark,OralMark,TotalMark")] StudentAssignment studentAssignment)
        {
            if (ModelState.IsValid)
            {
                db.StudentAssignments.Add(studentAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssignmentId = new SelectList(db.Assignments, "AssignmentId", "Title", studentAssignment.AssignmentId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FirstName", studentAssignment.StudentId);
            return View(studentAssignment);
        }

        // GET: TestStudentAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssignmentId = new SelectList(db.Assignments, "AssignmentId", "Title", studentAssignment.AssignmentId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FirstName", studentAssignment.StudentId);
            return View(studentAssignment);
        }

        // POST: TestStudentAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,AssignmentId,CodeMark,OralMark,TotalMark")] StudentAssignment studentAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssignmentId = new SelectList(db.Assignments, "AssignmentId", "Title", studentAssignment.AssignmentId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "FirstName", studentAssignment.StudentId);
            return View(studentAssignment);
        }

        // GET: TestStudentAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            if (studentAssignment == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignment);
        }

        // POST: TestStudentAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAssignment studentAssignment = db.StudentAssignments.Find(id);
            db.StudentAssignments.Remove(studentAssignment);
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
