using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Id")]
        public virtual User User { get; set; }
    }
}
