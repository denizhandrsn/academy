using Business.Requests.Users;

namespace Business.Requests.Instructors
{
    public class CreateInstructorRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public CreateUserRequest userRequest { get; set; } 
    }
}
