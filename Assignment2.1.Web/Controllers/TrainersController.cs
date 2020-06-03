using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2._1.Database;
using Assignment2._1.Entities;
using Assignment2._1.Services;
using PagedList;

namespace Assignment2._1.Web.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        public ActionResult TrainerTable(string sortOrder, string searchfirstname, string searchlastname, string searchsubject, int? page)
        {
            ViewBag.CurrentFirstName = searchfirstname;
            ViewBag.CurrentLastName = searchlastname;
            ViewBag.CurrentSubject = searchsubject;
            ViewBag.CurrentSortOrder = sortOrder;

            ViewBag.FirstNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";

            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.SubjectSortParam = sortOrder == "SubjectAsc" ? "SubjectDesc" : "SubjectAsc";

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";


            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();

            //======================FILTERS===============================
            //Filtering  FirstName
            if (!string.IsNullOrWhiteSpace(searchfirstname))
            {
                trainers = trainers.Where(x => x.FirstName.ToUpper().Contains(searchfirstname.ToUpper()));
            }
            //Filtering  LastName
            if (!string.IsNullOrWhiteSpace(searchlastname))
            {
                trainers = trainers.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            }
            switch (sortOrder)
            {
                case "FirstNameDesc": trainers = trainers.OrderByDescending(x => x.FirstName); ViewBag.FNView = "badge badge-danger"; break;
                case "LastNameAsc": trainers = trainers.OrderBy(x => x.LastName); ViewBag.LNView = "badge badge-success"; break;
                case "LastNameDesc": trainers = trainers.OrderByDescending(x => x.LastName); ViewBag.LNView = "badge badge-danger"; break;

                case "SubjectAsc": trainers = trainers.OrderBy(x => x.Subject); ViewBag.LNView = "badge badge-success"; break;
                case "SubjectDesc": trainers = trainers.OrderByDescending(x => x.Subject); ViewBag.LNView = "badge badge-danger"; break;


                default: trainers = trainers.OrderBy(x => x.FirstName); ViewBag.FNView = "badge badge-success"; break;

            }

            int pageSize = 10;
            int pageNumber = page ?? 1;  //nullable coehelesing operator


            return View(trainers.ToPagedList(pageNumber, pageSize));

        }

        // GET: TestStudents/SimpleDetails/
        public ActionResult TrainersDetails(int? id)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            //trainerRepository.Dispose();
            return View(trainer);
        }
    }
}