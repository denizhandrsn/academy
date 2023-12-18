using Business.Requests.Applications;
using Business.Requests.Courses;
using Business.Responses.Applications;
using Business.Responses.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        IDataResult<List<ListApplicationResponse>> GetAll();
        IResult Add(CreateApplicationRequest request);
        IResult Update(UpdateApplicationRequest request);
        IResult Delete(DeleteApplicationRequest request);
    }
}
