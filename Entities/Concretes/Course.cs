using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int StatusId { get; set; }
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Category Category { get; set; }


    }
}
