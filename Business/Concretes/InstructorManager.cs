using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Instructors;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IMapper _mapper;
        IInstructorDal _instructorDal;
        IUserService _userService;
        public InstructorManager(IMapper mapper,IInstructorDal instructorDal, IUserService userService)
        {
            _mapper = mapper;
            _instructorDal = instructorDal;
            _userService = userService;

        }
        public IDataResult<Instructor> Add(CreateInstructorRequest request)
        {
            CreateUserRequest userRequest = _mapper.Map<CreateUserRequest>(request.userRequest);
            var user = _userService.Add(userRequest);
            Instructor instructor = _mapper.Map<Instructor>(request);
            instructor.Id = user.Data.Id;
            _instructorDal.Add(instructor);

            return new SuccessDataResult<Instructor>(instructor,Messages.Added);
        }

        public IDataResult<List<ListUserResponse>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
