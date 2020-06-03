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
    public class PhotoRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Photo> GetAll()
        {
            return db.Photos.ToList();
        }

        //GetById
        public Photo GetById(int? id)
        {
            return db.Photos.Find(id);
        }
        //Insert
        public void Insert(Photo photo)
        {
            db.Entry(photo).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Photo photo)
        {
            db.Entry(photo).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Photo photo)
        {
            db.Entry(photo).State = EntityState.Deleted;
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
