using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Applications;
using Business.Responses.Applications;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        IMapper _mapper;
        IApplicationDal _applicationDal;

        public ApplicationManager(IMapper mapper, IApplicationDal applicationDal)
        {
            _mapper = mapper;
            _applicationDal = applicationDal;
        }

        public IResult Add(CreateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            _applicationDal.Add(application);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(DeleteApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            _applicationDal.Delete(application);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListApplicationResponse>> GetAll()
        {
            List<Application> applications = _applicationDal.GetAll(include: b => b.Include(b => b.Applicant)
            .Include(b => b.Applicant.User).Include(b => b.Course).Include(b => b.Course.CourseDetail)
            .Include(b => b.Course.CourseDetail.Status)
            );
            List<ListApplicationResponse> response = _mapper.Map<List<ListApplicationResponse>>(applications);
            return new SuccessDataResult<List<ListApplicationResponse>>(response,Messages.Listed);

        }

        public IResult Update(UpdateApplicationRequest request)
        {
            Application appliciation = _mapper.Map<Application>(request);
            _applicationDal.Update(appliciation);
            return new SuccessResult(Messages.Updated);
        }
    }
}
