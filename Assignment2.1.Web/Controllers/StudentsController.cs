using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2._1.Database;
using Assignment2._1.Entities;
using Assignment2._1.Services;
using PagedList.Mvc;
using PagedList;

namespace Assignment2._1.Web.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult StudentsTable(string sortOrder, string searchfirstname, string searchlastname, int? searchminage, int? searchmaxage, DateTime? searchmindate, DateTime? searchmaxdate, int? page, int? pSize)
        {

            ViewBag.CurrentFirstName = searchfirstname;
            ViewBag.CurrentLastName = searchlastname;
            ViewBag.CurrentMinAge = searchminage;
            ViewBag.CurrentMaxAge = searchmaxage;
            ViewBag.CurrentMinDate = searchmindate;
            ViewBag.CurrentMaxDate = searchmaxdate;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;


            ViewBag.FirstNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.AgeSortParam = sortOrder == "AgeAsc" ? "AgeDesc" : "AgeAsc";
            ViewBag.DateSortParam = sortOrder == "DateAsc" ? "DateDesc" : "DateAsc";
            ViewBag.DetailsSortParam = sortOrder == "DetailsAsc" ? "DetailsDesc" : "DetailsAsc";
            

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";
            ViewBag.AGView = "badge badge-primary";
            ViewBag.DTView = "badge badge-primary";
            

            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();
            //studentRepository.Dispose();

            //======================FILTERS===============================
            //Filtering  FirstName
            if (!string.IsNullOrWhiteSpace(searchfirstname))
            {
                students = students.Where(x => x.FirstName.ToUpper().Contains(searchfirstname.ToUpper()));
            }
            //Filtering  LastName
            if (!string.IsNullOrWhiteSpace(searchlastname))
            {
                students = students.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            }
            //Filtering  Minimum Age
            if (!(searchminage is null)) //40
            {
                students = students.Where(x => x.Age >= searchminage);
            }
            //Filtering  Maximum Age
            if (!(searchmaxage is null)) //50
            {
                students = students.Where(x => x.Age <= searchmaxage);
            }
            //Filtering Minimum Date
            if(!(searchmindate is null))
            {
                students = students.Where(x => x.DateOfBirth >= searchmindate);
            }
            //Filtering Maximum Date
            if (!(searchmaxdate is null))
            {
                students = students.Where(x => x.DateOfBirth >= searchmaxdate);
            }


            //Sorting
            switch (sortOrder)
            {
                case "FirstNameDesc": students = students.OrderByDescending(x => x.FirstName); ViewBag.FNView = "badge badge-danger"; break;
                case "LastNameAsc": students = students.OrderBy(x => x.LastName); ViewBag.LNView = "badge badge-success"; break;
                case "LastNameDesc": students = students.OrderByDescending(x => x.LastName); ViewBag.LNView = "badge badge-danger"; break;
                case "AgeAsc": students = students.OrderBy(x => x.Age); ViewBag.AGView = "badge badge-success"; break;
                case "AgeDesc": students = students.OrderByDescending(x => x.Age); ViewBag.AGView = "badge badge-danger"; break;
                case "DateAsc": students = students.OrderBy(x => x.DateOfBirth); ViewBag.AGView = "badge badge-success"; break;
                case "DateDesc": students = students.OrderByDescending(x => x.DateOfBirth); ViewBag.AGView = "badge badge-danger"; break;
                case "DetailsAsc": students = students.OrderBy(x => x.Courses.ToList()[0].Title); ViewBag.DTView = "badge badge-success"; break;
                case "DetailsDesc": students = students.OrderByDescending(x => x.Courses.ToList()[0].Title); ViewBag.DTView = "badge badge-danger"; break;
                default: students = students.OrderBy(x => x.FirstName); ViewBag.FNView = "badge badge-success"; break;

            }

            int pageSize = pSize ?? 10;
            int pageNumber = page ?? 1;


            return View(students.ToPagedList(pageNumber, pageSize));
        }
        
        // GET: TestStudents/SimpleDetails/
        public ActionResult SimpleDetails(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            // studentRepository.Dispose();
            return View(student);
        }
    }
}