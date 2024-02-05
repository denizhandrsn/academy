﻿using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.CourseDetails;
using Business.Responses.CourseDetails;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class CourseDetailManager : ICourseDetailService
    {
        IMapper _mapper;
        ICourseDetailDal _courseDetailDal;

        public CourseDetailManager(IMapper mapper, ICourseDetailDal courseDetailDal)
        {
            _mapper = mapper;
            _courseDetailDal = courseDetailDal;
        }

        public IDataResult<CourseDetail> Add(CreateCourseDetailRequest request)
        {
            CourseDetail courseDetail = _mapper.Map<CourseDetail>(request);
            _courseDetailDal.Add(courseDetail);
            return new SuccessDataResult<CourseDetail>(courseDetail);
        }

        public IResult Delete(DeleteCourseDetailRequest request)
        {
            CourseDetail courseDetail = _mapper.Map<CourseDetail>(request);
            _courseDetailDal.Delete(courseDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListCourseDetailResponse>> GetAll()
        {
            List<CourseDetail> courseDetails = _courseDetailDal.GetAll(include: b => b.Include(b => b.Instructor).Include(b => b.Category)
            .Include(b => b.Status).Include(b => b.Instructor.User)
            );
            List<ListCourseDetailResponse> responses = _mapper.Map<List<ListCourseDetailResponse>>(courseDetails);
            return new SuccessDataResult<List<ListCourseDetailResponse>>(responses, Messages.Listed);

        }

        public IResult Update(UpdateCourseDetailRequest request)
        {
            CourseDetail courseDetail = _mapper.Map<CourseDetail>(request);
            _courseDetailDal.Update(courseDetail);
            return new SuccessResult(Messages.Updated);
        }
    }
}
