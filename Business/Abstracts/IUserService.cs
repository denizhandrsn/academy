using Business.Requests.Users;
using Business.Responses.Users;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<ListUserResponse>> GetAll();
        IDataResult<User> Add(CreateUserRequest request);
        

    }
}
