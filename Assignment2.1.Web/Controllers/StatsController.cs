using Assignment2._1.Services;
using Assignment2._1.Web.Models;
using Assignment2._1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2._1.Web.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            StatsViewModel vm = new StatsViewModel();

            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();

            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();

            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignments = assignmentRepository.GetAll();

            vm.StudentsCount = students.Count();
            vm.CoursesCount = courses.Count();
            vm.TrainersCount = trainers.Count();
            vm.AssignmentsCount = assignments.Count();

            //Grouping Course Student
            vm.StudentsPerCourse = students
                         .SelectMany(x => x.Courses.Select(y => new
                         {
                             Key = y,
                             Value = x
                         }))
                         .GroupBy(y => y.Key, x => x.Value);

            //Grouping Course Trainer
            vm.TrainersPerCourse = trainers
                        .SelectMany(x => x.Courses.Select(y => new
                        {
                            Key = y,
                            Value = x
                        }))
                        .GroupBy(y => y.Key, x => x.Value);

            //Grouping Course Assignment
            vm.AssignmentPerCourse = courses
                        .SelectMany(x => x.Assignments.Select(y => new
                        {
                            Key = x,
                            Value = y
                        }))
                        .GroupBy(y => y.Key, x => x.Value);

            vm.Students = students;
            vm.Courses = courses;
            vm.Assignments = assignments;














            return View(vm);
        }
    }
}