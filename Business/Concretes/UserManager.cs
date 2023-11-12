using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Users;
using Business.Responses.Courses;
using Business.Responses.Users;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IMapper _mapper;
        IUserDal _userDal;
        public UserManager(IUserDal userDal,IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }
        public IDataResult<User> Add(CreateUserRequest request)
        {

            User user = _mapper.Map<User>(request);
            _userDal.Add(user);
            return new SuccessDataResult<User>(user,Messages.Added);
        }

        public IDataResult<List<ListUserResponse>> GetAll()
        {
            

            List<User> users = _userDal.GetAll();
            List<ListUserResponse> responses = _mapper.Map<List<ListUserResponse>>(users);
            return new SuccessDataResult<List<ListUserResponse>>(responses);
        }
    }
}
