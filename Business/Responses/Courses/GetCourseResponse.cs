namespace Business.Responses.Courses
{
    public class GetCourseResponse
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string CourseDetailDescription { get; set; }
        public string CourseDetailCategoryName { get; set; }
        public string CourseDetailStatusName { get; set; }
        public string CourseDetailInstructorUserFirstName { get; set; }
        public string CourseDetailInstructorUserLastName { get; set; }
    }
}
