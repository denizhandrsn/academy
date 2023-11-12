namespace Business.Responses.Courses
{
    public class ListCourseResponse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int StatusId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }
        public string CategoryName { get; set; }
        public string InstructorUserFirstName { get; set; }
        public string InstructorUserLastName { get; set; }
      
    }
}
