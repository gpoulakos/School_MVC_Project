﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment2._1.Entities;

namespace Assignment2._1.Web.Models
{
    public class StatsViewModel
    {
        public int CoursesCount { get; set; }
        public int StudentsCount { get; set; }
        public int TrainersCount { get; set; }
        public int AssignmentsCount { get; set; }


        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }
        public IEnumerable<IGrouping<Course, Student>> StudentsPerCourse { get; set; }
        public IEnumerable<IGrouping<Course, Trainer>> TrainersPerCourse { get; set; }
        public IEnumerable<IGrouping<Course, Assignment>> AssignmentPerCourse { get; set; }
    }
}