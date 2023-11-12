using Business.Requests.Instructors;
using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IDataResult<List<ListUserResponse>> GetAll();
        IDataResult<Instructor> Add(CreateInstructorRequest request);
    }
}
