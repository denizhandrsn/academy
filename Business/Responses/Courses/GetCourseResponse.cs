namespace Business.Responses.Courses
{
    public class GetCourseResponse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int StatusId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
