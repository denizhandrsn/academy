using DataAccess.Abstracts;
using DataAccess.Concretes.AdoNet.Helpers;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess.Concretes.AdoNet
{
    public class AnCourseDal:ICourseDal //DRY Dont repeat yourself
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BootCode; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
        List<Course> courseList;

        public AnCourseDal()
        {
            courseList = new List<Course>();
        }

        public void Add(Course course)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection<Course>("INSERT INTO Courses Values" +
                " (@CategoryId,@InstructorId,@StatusId,@CourseName,@CoursePrice)",course);
            if (affectedRowCount == 0) { throw new Exception("No affected Row"); }

        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            List<Course> list = DbHelper.CreateReadCommand<Course>("Select * from Courses");
            return list;
            
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll(Expression<Func<Course, bool>>? predicate = null, Func<IQueryable<Course>, IIncludableQueryable<Course, object>>? include = null, bool enableTracking = true)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<CourseDetailDto> GetCourseDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
