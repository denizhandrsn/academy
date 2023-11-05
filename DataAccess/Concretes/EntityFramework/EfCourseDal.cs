using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, BootCodeContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (BootCodeContext context = new BootCodeContext()) 
            {
                var result = from c in context.Courses
                             join cat in context.Categories
                             on c.CategoryId equals cat.Id
                             join i in context.Instructors
                             on c.InstructorId equals i.Id
                             select new CourseDetailDto
                             {
                                 CourseId = c.Id,
                                 CourseName = c.CourseName,
                                 CategoryName = cat.CategoryName,
                                 CoursePrice = c.CoursePrice,
                                
                             };
                return result.ToList();
            }
        }
    }
}
