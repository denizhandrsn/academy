using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class BootCodeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BootCode;Trusted_Connection = true");


        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Status> Statuses { get; set; }


    }
}
