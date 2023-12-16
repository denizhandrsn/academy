using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Business.Responses.Users;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IDataResult<List<ListInstructorResponse>> GetAll();
        IDataResult<Instructor> Add(CreateInstructorRequest request);
    }
}
