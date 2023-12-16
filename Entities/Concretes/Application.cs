using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application:IEntity
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int CourseId { get; set; }
        public int StatusId { get; set; }

        public virtual Applicant Applicant { get; set; }
        public virtual Course Course { get; set; }
        public virtual Status Status { get; set; }
    }
}
