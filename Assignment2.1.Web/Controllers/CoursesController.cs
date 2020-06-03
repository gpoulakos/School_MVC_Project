using Assignment2._1.Database;
using Assignment2._1.Entities;
using Assignment2._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;

namespace Assignment2._1.Web.Controllers
{
    
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult CourseTable(string sortOrder, string searchtitle, string searchstream, string searchtype, DateTime? searchminstartdate, DateTime? searchmaxstartdate, DateTime? searchminenddate, DateTime? searchmaxenddate, int? page, int? pSize)
        {
            ViewBag.CurrenTitle = searchtitle;
            ViewBag.CurrentStream = searchstream;
            ViewBag.CurrentType = searchtype;

            ViewBag.CurrentMinStartDate = searchminstartdate;
            ViewBag.CurrentMaxStartDate = searchmaxstartdate;

            ViewBag.CurrentMinEndDate = searchminenddate;
            ViewBag.CurrentMaxEndDate = searchmaxenddate;

            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";

            ViewBag.StreamSortParam = sortOrder == "StreamAsc" ? "StreamDesc" : "StreamAsc";
            ViewBag.TypeSortParam = sortOrder == "TypeAsc" ? "TypeDesc" : "TypeAsc";

            ViewBag.StartDateSortParam = sortOrder == "StartDateAsc" ? "StartDateDesc" : "StartDateAsc";
            ViewBag.EndDateSortParam = sortOrder == "EndDateAsc" ? "EndDateDesc" : "EndDateAsc";

            ViewBag.DetailsSortParam = sortOrder == "DetailsAsc" ? "DetailsDesc" : "DetailsAsc";

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";
            ViewBag.AGView = "badge badge-primary";
            ViewBag.DTView = "badge badge-primary";



            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();

            //======================FILTERS===============================
            //Filtering  title
            if (!string.IsNullOrWhiteSpace(searchtitle))
            {
                courses = courses.Where(x => x.Title.ToUpper().Contains(searchtitle.ToUpper()));
            }
            //Filtering  stream
            if (!string.IsNullOrWhiteSpace(searchstream))
            {
                courses = courses.Where(x => x.Stream.ToUpper().Contains(searchstream.ToUpper()));
            }
            //Filtering  type
            if (!string.IsNullOrWhiteSpace(searchtype))
            {
                courses = courses.Where(x => x.Type.ToUpper().Contains(searchtype.ToUpper()));
            }
            //Filtering  Minimum start date
            if (!(searchminstartdate is null)) //40
            {
                courses = courses.Where(x => x.StartDate >= searchminstartdate);
            }
            //Filtering  Maximum start date
            if (!(searchmaxstartdate is null)) //50
            {
                courses = courses.Where(x => x.StartDate <= searchmaxstartdate);
            }
            //Filtering  Minimum end date
            if (!(searchminenddate is null)) //40
            {
                courses = courses.Where(x => x.EndDate >= searchminenddate);
            }
            //Filtering  Maximum end date
            if (!(searchmaxenddate is null)) //50
            {
                courses = courses.Where(x => x.EndDate <= searchmaxenddate);
            }
            //Sorting
            switch (sortOrder)
            {
                case "TitleDesc": courses = courses.OrderByDescending(x => x.Title); ViewBag.FNView = "badge badge-danger"; break;
                case "StreamAsc": courses = courses.OrderBy(x => x.Stream); ViewBag.LNView = "badge badge-success"; break;
                case "TypeDesc": courses = courses.OrderByDescending(x => x.Type); ViewBag.LNView = "badge badge-danger"; break;

                case "StartDateAsc": courses = courses.OrderBy(x => x.StartDate); ViewBag.AGView = "badge badge-success"; break;
                case "StartDateDesc": courses = courses.OrderByDescending(x => x.StartDate); ViewBag.AGView = "badge badge-danger"; break;

                case "EndDateAsc": courses = courses.OrderBy(x => x.EndDate); ViewBag.AGView = "badge badge-success"; break;
                case "EndDateDesc": courses = courses.OrderByDescending(x => x.EndDate); ViewBag.AGView = "badge badge-danger"; break;

                case "DetailsAsc": courses = courses.OrderBy(x => x.Students.ToList()[0].LastName); ViewBag.DTView = "badge badge-success"; break;
                case "DetailsDesc": courses = courses.OrderBy(x => x.Assignments.ToList()[0].Title); ViewBag.DTView = "badge badge-danger"; break;
                default: courses = courses.OrderBy(x => x.Title); ViewBag.FNView = "badge badge-success"; break;

            }

            int pageSize = pSize ?? 5;
            int pageNumber = page ?? 1;  //nullable coehelesing operator

            return View(courses.ToPagedList(pageNumber, pageSize));
        }



        // GET: SimpleDetails/
        public ActionResult CourseDetails(int? id)
        {
            CourseRepository courseRepository = new CourseRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            //courseRepository.Dispose();
            return View(course);

        }
    }
}