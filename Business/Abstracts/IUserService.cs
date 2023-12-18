using Business.Requests.Courses;
using Business.Requests.Users;
using Business.Responses.Users;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<ListUserResponse>> GetAll();
        IDataResult<User> Add(CreateUserRequest request);
        IResult Update(UpdateUserRequest request);
        IResult Delete(DeleteUserRequest request);
    }
}
