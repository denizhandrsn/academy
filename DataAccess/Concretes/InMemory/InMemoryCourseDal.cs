using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course{Id =1,CourseName="C#",CoursePrice=45,CategoryId=1,InstructorId = 1},
                new Course{Id =2,CourseName="Java",CoursePrice=75,CategoryId=1,InstructorId = 2},
                new Course{Id =3,CourseName="Python",CoursePrice=85,CategoryId=1,InstructorId = 1}
            };
        }


        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.Id == course.Id);
            _courses.Remove(courseToDelete);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            throw new NotImplementedException();
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
            return _courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseDetailDto> GetCourseDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
            courseToUpdate.Id = course.Id;
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CoursePrice = course.CoursePrice;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.CategoryId = course.CategoryId;

        }
    }
}
