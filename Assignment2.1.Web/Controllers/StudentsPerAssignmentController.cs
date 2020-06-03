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
    public class StudentsPerAssignmentController : Controller
    {
        MyDatabase db = new MyDatabase();

        // GET: StudentAssignments
        public ActionResult StudentsPerAssignmentTable()
        {
            var studentAssignments = db.StudentAssignments.Include(s => s.Assignment).Include(s => s.Student);
            return View(studentAssignments.ToList());
        }

    }
}