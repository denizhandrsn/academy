using AutoMapper;
using Business.Requests.CourseDetails;
using Business.Responses.CourseDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseDetailMapperProfiles:Profile
    {
        public CourseDetailMapperProfiles()
        {
            CreateMap<CourseDetail, ListCourseDetailResponse>();
            CreateMap<CreateCourseDetailRequest, CourseDetail>();
            CreateMap<UpdateCourseDetailRequest, CourseDetail>();
            CreateMap<DeleteCourseDetailRequest, CourseDetail>();
        }
    }
}
