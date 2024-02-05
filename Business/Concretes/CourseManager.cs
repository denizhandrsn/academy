﻿using AutoMapper;
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
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Specialized;

namespace Business.Concretes
{

    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        ICourseDetailService _courseDetailService;
        
        public CourseManager(ICourseDal courseDal, IMapper mapper,ICourseDetailService courseDetailService) //Dependecy Injection
        {
            
            _courseDal = courseDal;
            _mapper = mapper;
            _courseDetailService = courseDetailService;
        }


        [ValidationAspect(typeof(CourseValidator))]
        [TransactionAspect]
        public IResult Add(CreateCourseRequest request)
        {
            CreateCourseDetailRequest courseDetailRequest = _mapper.Map<CreateCourseDetailRequest>(request.CreateCourseDetailRequest);
            var detail = _courseDetailService.Add(courseDetailRequest);
            Course course = _mapper.Map<Course>(request);
            //Course detiali course mapliycez
            course.CourseDetail = detail.Data;
            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(DeleteCourseRequest request)
        {
            Course course = _mapper.Map<Course>(request);
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListCourseResponse>> GetAll()
        {
            List<Course> courses = _courseDal.GetAll(include: b => b.Include(b => b.CourseDetail).Include(b =>
            b.CourseDetail.Category).Include(b => b.CourseDetail.Instructor).Include(b => b.CourseDetail.Status)
            .Include(b => b.CourseDetail.Instructor.User)
            );
            List<ListCourseResponse> responses = _mapper.Map<List<ListCourseResponse>>(courses);

            return new SuccessDataResult<List<ListCourseResponse>>(responses, Messages.Listed);
        }

        public IDataResult<List<ListCourseResponse>> GetAllByCategory(int categoryId)
        {
            List<Course> course = _courseDal.GetAll(predicate: b=> b.CourseDetail.CategoryId == categoryId, include:
                b => b.Include(b => b.CourseDetail).Include(b => b.CourseDetail.Category)
                .Include(b => b.CourseDetail.Status).Include(b => b.CourseDetail.Instructor)
                .Include(b => b.CourseDetail.Instructor.User));
            List<ListCourseResponse> responses = _mapper.Map<List<ListCourseResponse>>(course);
            return new SuccessDataResult<List<ListCourseResponse>>(responses,Messages.Listed);

        }

        

        public IDataResult<GetCourseResponse> GetById(GetCourseRequest request)
        {
            Course course = _courseDal.Get(predicate: b => b.Id == request.Id, include: b=> b.Include(b => b.CourseDetail)
            .Include(b => b.CourseDetail.Category).Include(b => b.CourseDetail.Instructor).Include(b => b.CourseDetail.Status)
            .Include(b => b.CourseDetail.Instructor.User));
            GetCourseResponse response = _mapper.Map<GetCourseResponse>(course);
            return new SuccessDataResult<GetCourseResponse>(response, Messages.Getted);
            
        }

        public IResult Update(UpdateCourseRequest request)
        {
            Course course = _mapper.Map<Course>(request);
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }

        
    }
}
