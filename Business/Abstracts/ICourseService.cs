using Business.Requests.Courses;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IResult Add(CreateCourseRequest request);
        
        IDataResult<List<Course>> GetAllByCategory(int categoryId);
        IDataResult<List<Course>> GetAllByPriceRange(decimal min,decimal max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();

    }
}
