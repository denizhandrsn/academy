using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Applicants;
using Business.Requests.Users;
using Business.Responses.Applicants;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {
        IApplicantDal _applicantDal;
        IMapper _mapper;
        IUserService _userService;

        public ApplicantManager(IApplicantDal applicantDal, IMapper mapper, IUserService userService)
        {
            _applicantDal = applicantDal;
            _mapper = mapper;
            _userService = userService;
        }

        public IResult Add(CreateApplicantRequest request)
        {
            CreateUserRequest userRequest = _mapper.Map<CreateUserRequest>(request.CreateUserRequest);
            var user = _userService.Add(userRequest);
            Applicant applicant = _mapper.Map<Applicant>(request);
            applicant.User = _mapper.Map<User>(request.CreateUserRequest);//requesti user değişkeni ile değiştir
            applicant.User.Id = user.Data.Id;
            _applicantDal.Add(applicant);
            return new SuccessDataResult<Applicant>(applicant);

        }

        public IResult Delete(DeleteApplicantRequest request)
        {
            Applicant applicant = _mapper.Map<Applicant>(request);
            _applicantDal.Delete(applicant);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListApplicantResponse>> GetAll()
        {
            List<Applicant> applicants = _applicantDal.GetAll(include: b => b.Include(b => b.User));
            List<ListApplicantResponse> responses = _mapper.Map<List<ListApplicantResponse>>(applicants);
            return new SuccessDataResult<List<ListApplicantResponse>>(responses,Messages.Listed);
        }

        public IResult Update(UpdateApplicantRequest request)
        {
            UpdateUserRequest userRequest = _mapper.Map<UpdateUserRequest>(request.UserRequest);
            var user = _userService.Update(userRequest);
            Applicant applicant = _mapper.Map<Applicant>(request);
            applicant.User = _mapper.Map<User>(userRequest);
            _applicantDal.Update(applicant);
            return new SuccessResult(Messages.Updated);
        }
    }
}
