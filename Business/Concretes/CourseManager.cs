using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Constants;
using Business.Requests.Courses;
using Business.Requests.Users;
using Business.Responses.Courses;
using Business.Responses.Instructors;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.ValidationAspect;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Exceptions.BusinessExceptions;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using Entities.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.IdentityModel.Tokens;

namespace Business.Concretes
{
    
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        IUserService _userService;
        CourseBusinessRules _courseBusinessRules;
        public CourseManager(ICourseDal courseDal, IMapper mapper,IUserService userService, CourseBusinessRules courseBusinessRules) //Dependecy Injection
        {
            _courseBusinessRules = courseBusinessRules;
            _courseDal = courseDal;
            _mapper = mapper;
            _userService = userService;
        }


        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(CreateCourseRequest request)
        {
            CreateUserRequest userRequest = _mapper.Map<CreateUserRequest>(request.CreateUser);
            var user = _userService.Add(userRequest);
            Course course = _mapper.Map<Course>(request);
            course.Id = userRequest.Id;

            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        

        public IDataResult<List<ListCourseResponse>> GetAll()
        {
            List<Course> courses = _courseDal.GetAll(include: b => b.Include(b => b.Instructor.User).Include(b => b.Category));
            List<ListCourseResponse> responses = _mapper.Map<List<ListCourseResponse>>(courses);

            return new SuccessDataResult<List<ListCourseResponse>>(responses, Messages.Listed);
        }

        public IDataResult<List<Course>> GetAllByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == categoryId));
        }

        public IDataResult<List<Course>> GetAllByPriceRange(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CoursePrice <= max && c.CoursePrice >= min));
        }



        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IResult Update(UpdateCourseRequest request)
        {

            Course course = _mapper.Map<Course>(request);
            List<Course> list = _courseDal.GetAll();
            


            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }

        
    }
}
