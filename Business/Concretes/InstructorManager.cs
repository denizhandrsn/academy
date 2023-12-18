using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Instructors;
using Business.Requests.Users;
using Business.Responses.Applicants;
using Business.Responses.Instructors;
using Business.Responses.Users;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

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
            instructor.User = _mapper.Map<User>(request.userRequest);//requesti user değişkeni ile değiştir
            instructor.User.Id = user.Data.Id;
            _instructorDal.Add(instructor);

            return new SuccessDataResult<Instructor>(instructor,Messages.Added);
        }

        public IResult Delete(DeleteInstructorRequest request)
        {
            Instructor instructor = _mapper.Map<Instructor>(request);
            DeleteUserRequest userRequest = _mapper.Map<DeleteUserRequest>(request.userRequest);
            _userService.Delete(userRequest);
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListInstructorResponse>> GetAll()
        {
            List<Instructor> instructors = _instructorDal.GetAll(include: b => b.Include(b => b.User));
            List<ListInstructorResponse> responses = _mapper.Map<List<ListInstructorResponse>>(instructors);
            return new SuccessDataResult<List<ListInstructorResponse>>(responses, Messages.Listed);
        }

        public IResult Update(UpdateInstructorRequest request)
        {
            UpdateUserRequest userRequest = _mapper.Map<UpdateUserRequest>(request.userRequest);
            _userService.Update(userRequest);
            Instructor instructor = _mapper.Map<Instructor>(request);
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.Updated);
            
        }
    }
}
