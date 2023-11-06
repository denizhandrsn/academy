using AutoMapper;
using Business.Requests.Courses;
using Business.Responses.Courses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseMapperProfiles:Profile
    {
        public CourseMapperProfiles()
        {
            CreateMap<CreateCourseRequest, Course>();
            CreateMap<Course, GetCourseResponse>();
            CreateMap<Course, ListCourseResponse>().ForMember(fn => fn.FirstName, o => o.MapFrom(t => t.Instructor.User.FirstName))
                .ForMember(ln => ln.LastName, o => o.MapFrom(t => t.Instructor.User.LastName));
            
            
        }
    }
}
