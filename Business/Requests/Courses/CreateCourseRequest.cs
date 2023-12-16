using Business.Requests.CourseDetails;
using Business.Requests.Users;

namespace Business.Requests.Courses
{
    public class CreateCourseRequest
    {
        
        public int ModuleId { get; set; }
        public CreateCourseDetailRequest CreateCourseDetailRequest { get; set; }
    }
}
