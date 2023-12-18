using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CourseDetails
{
    public class ListCourseDetailResponse
    {
        public string CategoryName { get; set; }
        public string InstructorUserFirstName { get; set; }
        public string InstructorUserLastName { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public string CourseName { get; set; }
    }
}
