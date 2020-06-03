using Assignment2._1.Database;
using Assignment2._1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Services
{
    public class CourseRepository
    {
        MyDatabase db = new MyDatabase();


        //Get All
        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        //Get by Id
        public Course GetById(int? id)
        {
            return db.Courses.Find(id);
        }
        //Insert
        public void InsertCourse(Course course)
        {
            db.Entry(course).State = EntityState.Added;
            db.SaveChanges();
        }
        //Update 
        public void UpdateCourse(Course course)
        {
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Delete
        public void DeleteCourse(Course course)
        {
            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
