using Business.Requests.Courses;
using Business.Requests.Modules;
using Business.Responses.Courses;
using Business.Responses.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IModuleService
    {
        IDataResult<List<ListModuleResponse>> GetAll();
        IResult Add(CreateModuleRequest request);
        IResult Update(UpdateModuleRequest request);
        IResult Delete(DeleteModuleRequest request);
    }
}
