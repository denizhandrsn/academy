using Business.Requests.Users;

namespace Business.Requests.Courses
{
    public class CreateCourseRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int StatusId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }

        public CreateUserRequest CreateUser { get; set; }
    }
}
