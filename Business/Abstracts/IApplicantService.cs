using Business.Requests.Applicants;
using Business.Requests.Courses;
using Business.Responses.Applicants;
using Business.Responses.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicantService
    {
        IDataResult<List<ListApplicantResponse>> GetAll();
        IResult Add(CreateApplicantRequest request);
    }
}
