using Business.Concretes;
using DataAccess.Concretes.AdoNet;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());


            Console.WriteLine(courseManager.GetAll().Message);
            foreach (var item in courseManager.GetAll().Data)
            {
                Console.WriteLine(item.CourseName + " " + item.CoursePrice);
            }

        }
    }
}