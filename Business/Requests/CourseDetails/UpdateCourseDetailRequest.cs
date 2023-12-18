using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.CourseDetails
{
    public class UpdateCourseDetailRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int StatusId { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public string CourseName { get; set; }
    }
}
