using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Applicant:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
