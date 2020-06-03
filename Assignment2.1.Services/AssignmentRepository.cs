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
    public class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Assignment> GetAll()
        {
            return db.Assignments.ToList();
        }

        //GetById
        public Assignment GetById(int? id)
        {
            return db.Assignments.Find(id);
        }
        //Insert 
        public void InsertAssignment(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update 
        public void UpdateAssignment(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete 
        public void DeleteAssignment(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Deleted;
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
