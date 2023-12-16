using Business.Requests.Courses;
using Business.Requests.Statuses;
using Business.Responses.Courses;
using Business.Responses.Statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IStatusService
    {
        IDataResult<List<ListStatusResponse>> GetAll();
        IResult Add(CreateStatusRequest request);
    }
}
