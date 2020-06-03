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
    public class TrainerRepository
    {
        MyDatabase db = new MyDatabase();

        //Get All
        public IEnumerable<Trainer> GetAll()
        {
            return db.Trainers.ToList();
        }

        //Get by Id
        public Trainer GetById(int? id)
        {
            return db.Trainers.Find(id);
        }
        //Insert
        public void InsertTrainer(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Added;
            db.SaveChanges();
        }
        //Update
        public void UpdateTrainer(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Delete
        public void DeleteTrainer(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Deleted;
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
