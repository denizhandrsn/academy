using Business.Requests.Applications;
using Business.Requests.OperationClaim;
using Business.Responses.Applications;
using Business.Responses.OperationClaim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        IDataResult<List<ListOperationClaimResponse>> GetAll();
        IResult Add(CreateOperationClaimRequest request);
        IResult Update(UpdateOperationClaimRequest request);
        IResult Delete(DeleteOperationClaimRequest request);
    }
}
