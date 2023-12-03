using Business.Requests.Instructors;
using Business.Responses.Users;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IDataResult<List<ListUserResponse>> GetAll();
        IDataResult<Instructor> Add(CreateInstructorRequest request);
    }
}
