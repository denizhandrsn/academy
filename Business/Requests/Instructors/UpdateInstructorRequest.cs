using Business.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Instructors
{
    public class UpdateInstructorRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public UpdateUserRequest userRequest { get; set; }
    }
}
