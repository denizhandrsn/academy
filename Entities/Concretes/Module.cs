using Entities.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Module:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Course Course { get; set; }
    }
}
