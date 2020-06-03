using Assignment2._1.Database;
using Assignment2._1.Entities;
using Assignment2._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDatabase db = new MyDatabase();



            //StudentRepository studentRepository = new StudentRepository();
            //var lista = studentRepository.GetAll();
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item.LastName);
            //}

            //foreach (var trainer in db.Trainers.ToList())
            //{
            //    Console.WriteLine(trainer.FirstName + " " + trainer.LastName);
            //    foreach (var course in trainer.Courses)
            //    {
            //        Console.WriteLine(course.Title);
            //        foreach (var photos in trainer.Photos)
            //        {
            //            Console.WriteLine(photos.Url);
            //        }
            //    }

            //}
            //Console.WriteLine("===================================================================");

        }
    }
}
