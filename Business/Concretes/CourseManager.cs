using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Constants;
using Business.Requests.CourseDetails;
using Business.Requests.Courses;
using Business.Requests.Users;
using Business.Responses.Courses;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.CachingAspect;
using Core.Aspects.TransactionAspect;
using Core.Aspects.ValidationAspect;
using DataAccess.Abstracts;

using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;

namespace Business.Concretes
{

    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        ICourseDetailService _courseDetailService;
        CourseBusinessRules _courseBusinessRules;
        public CourseManager(ICourseDal courseDal, IMapper mapper,ICourseDetailService courseDetailService, CourseBusinessRules courseBusinessRules) //Dependecy Injection
        {
            _courseBusinessRules = courseBusinessRules;
            _courseDal = courseDal;
            _mapper = mapper;
            _courseDetailService = courseDetailService;
        }


        [ValidationAspect(typeof(CourseValidator))]
        [TransactionAspect]
        [CacheAspect(duration:10)]
        public IResult Add(CreateCourseRequest request)
        {
            
            CreateCourseDetailRequest courseDetailRequest = _mapper.Map<CreateCourseDetailRequest>(request.CreateCourseDetailRequest);
            var detail = _courseDetailService.Add(courseDetailRequest);
            Course course = _mapper.Map<Course>(request);
            course.Id = detail.Data.Id;
            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        

        public IDataResult<List<ListCourseResponse>> GetAll()
        {
            List<Course> courses = _courseDal.GetAll(include: b => b.Include(b => b.CourseDetail).Include(b => b.Module).Include(b =>
            b.CourseDetail.Category).Include(b => b.CourseDetail.Instructor).Include(b => b.CourseDetail.Status)
            );
            List<ListCourseResponse> responses = _mapper.Map<List<ListCourseResponse>>(courses);

            return new SuccessDataResult<List<ListCourseResponse>>(responses, Messages.Listed);
        }

        public IDataResult<List<Course>> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAllByPriceRange(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UpdateCourseRequest request)
        {
            Course course = _mapper.Map<Course>(request);
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }

        
    }
}
