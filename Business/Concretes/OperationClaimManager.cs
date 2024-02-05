using AutoMapper;
using Business.Abstracts;
using Business.Requests.OperationClaim;
using Business.Responses.OperationClaim;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationClaimDal;
        IMapper _mapper;

        public OperationClaimManager(IOperationClaimDal operationClaimDal, IMapper mapper)
        {
            _operationClaimDal = operationClaimDal;
            _mapper = mapper;
        }

        public IResult Add(CreateOperationClaimRequest request)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(DeleteOperationClaimRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListOperationClaimResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(UpdateOperationClaimRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
