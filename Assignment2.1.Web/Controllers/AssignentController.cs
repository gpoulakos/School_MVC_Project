using Assignment2._1.Entities;
using Assignment2._1.Services;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Assignment2._1.Web.Controllers
{
    public class AssignentController : Controller
    {
        // GET: Assignent
        public ActionResult AssignmentTable(string sortOrder,string searchtitle, string searchdescription, DateTime? searchminsubdatetime, DateTime? searchmaxsubdatetime, int? page, int? pSize)
        {
            ViewBag.CurrenTitle = searchtitle;
            ViewBag.CurrentDescription = searchdescription;
            ViewBag.CurrentMinSubDateTime = searchminsubdatetime;
            ViewBag.CurrentMaxSubDateTime = searchmaxsubdatetime;


            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.DescriptionSortParam = sortOrder == "DescriptionAsc" ? "DescriptionDesc" : "DescriptionAsc";
            ViewBag.SubDateTimeSortParam = sortOrder == "SubDateTimeAsc" ? "SubDateTimeDesc" : "SubDateTimeAsc";

            ViewBag.DetailsSortParam = sortOrder == "DetailsAsc" ? "DetailsDesc" : "DetailsAsc";

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";
            ViewBag.AGView = "badge badge-primary";
            ViewBag.DTView = "badge badge-primary";


            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignments = assignmentRepository.GetAll();
            //======================FILTERS===============================
            //Filtering  title
            if (!string.IsNullOrWhiteSpace(searchtitle))
            {
                assignments = assignments.Where(x => x.Title.ToUpper().Contains(searchtitle.ToUpper()));
            }
            //Filtering  description
            if (!string.IsNullOrWhiteSpace(searchdescription))
            {
                assignments = assignments.Where(x => x.Description.ToUpper().Contains(searchdescription.ToUpper()));
            }
            //Filtering  Minimum submission date
            if (!(searchminsubdatetime is null)) //40
            {
                assignments = assignments.Where(x => x.SubDateTime >= searchminsubdatetime);
            }
            //Filtering  Maximum submission date
            if (!(searchmaxsubdatetime is null)) //50
            {
                assignments = assignments.Where(x => x.SubDateTime <= searchmaxsubdatetime);
            }
            //Sorting
            switch (sortOrder)
            {
                case "TitleDesc": assignments = assignments.OrderByDescending(x => x.Title); ViewBag.FNView = "badge badge-danger"; break;
                case "StreamAsc": assignments = assignments.OrderBy(x => x.Description); ViewBag.LNView = "badge badge-success"; break;

                case "SubDateTimeAsc": assignments = assignments.OrderBy(x => x.SubDateTime); ViewBag.AGView = "badge badge-success"; break;
                case "SubDateTimDesc": assignments = assignments.OrderByDescending(x => x.SubDateTime); ViewBag.AGView = "badge badge-danger"; break;
            }

            int pageSize = pSize ?? 5;
            int pageNumber = page ?? 1;  //nullable coehelesing operator

            return View(assignments.ToPagedList(pageNumber, pageSize));
        }

        // GET: SimpleDetails/
        public ActionResult AssignmentDetails(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignmentRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            //courseRepository.Dispose();
            return View(assignment);
        }
    }
}