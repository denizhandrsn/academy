using AutoMapper;
using Business.Requests.Courses;
using Business.Responses.Courses;

namespace Business.Profiles
{
    public class CourseMapperProfiles:Profile
    {
        public CourseMapperProfiles()
        {
            CreateMap<CreateCourseRequest, Course>();
            CreateMap<Course, GetCourseResponse>();
            CreateMap<Course, ListCourseResponse>().ReverseMap();
            CreateMap<List<Course>,ListCourseResponse>().ReverseMap();
            
            
        }
    }
}
