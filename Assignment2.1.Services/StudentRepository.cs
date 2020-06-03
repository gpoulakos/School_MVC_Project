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
    public class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        //Get All
        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        //Get by Id
        public Student GetById(int? id)
        {
            return db.Students.Find(id);
        }
        //Insert Student
        public void InsertStudent(Student student)
        {
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
        }
        //Update
        public void UpdateStudent(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Delete
        public void DeleteStudent(Student student)
        {
            db.Entry(student).State = EntityState.Deleted;
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
