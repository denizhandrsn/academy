using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Services.Mailing;
using DataAccess.Abstracts;

namespace Business.Concretes;

public class UserManager : IUserService
{
    IMapper _mapper;
    IUserDal _userDal;
    IEmailService _emailService;
    public UserManager(IUserDal userDal,IMapper mapper,IEmailService emailService)
    {
        _emailService = emailService;
        _userDal = userDal;
        _mapper = mapper;
    }
    public IDataResult<User> Add(CreateUserRequest request)
    {
        User user = _mapper.Map<User>(request);
        _userDal.Add(user);
        sendTestEmail(user);
        return new SuccessDataResult<User>(user,Messages.Added);
    }

    public IResult Delete(DeleteUserRequest request)
    {
        User user = _mapper.Map<User>(request);
        _userDal.Delete(user);
        return new SuccessResult(Messages.Deleted);
    }

    public IDataResult<List<ListUserResponse>> GetAll()
    {
        List<User> users = _userDal.GetAll();
        List<ListUserResponse> responses = _mapper.Map<List<ListUserResponse>>(users);
        return new SuccessDataResult<List<ListUserResponse>>(responses);
    }

    public IResult Update(UpdateUserRequest request)
    {
        User user = _mapper.Map<User>(request);
        _userDal.Update(user);
        return new SuccessResult(Messages.Updated);
    }
    public void sendTestEmail(User user)
    {
        string message = $@"<p>Test Mail Sent";
        _emailService.Send(to: user.Email, subject:"Deneme",
            html:$@"<h4> Verify Email</h4>
                        <p>Thanks for testing</p> {message}");
    }
}
