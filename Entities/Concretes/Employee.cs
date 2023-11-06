using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string Role { get; set; }
    }
}
