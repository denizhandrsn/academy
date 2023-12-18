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
        public int ModuleId { get; set; }

        public virtual CourseDetail CourseDetail { get; set; }
 
    }
}
