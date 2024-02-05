using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Statuses;
using Business.Responses.Statuses;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class StatusManager : IStatusService
    {
        IMapper _mapper;
        IStatusDal _statusDal;

        public StatusManager(IMapper mapper, IStatusDal statusDal)
        {
            _mapper = mapper;
            _statusDal = statusDal;
        }

        public IResult Add(CreateStatusRequest request)
        {
            Status status = _mapper.Map<Status>(request);
            _statusDal.Add(status);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(DeleteStatusRequest request)
        {
            Status status = _mapper.Map<Status>(request);
            _statusDal.Delete(status);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListStatusResponse>> GetAll()
        {
            List<Status> statuses = _statusDal.GetAll();
            List<ListStatusResponse> response = _mapper.Map<List<ListStatusResponse>>(statuses);
            return new SuccessDataResult<List<ListStatusResponse>>(response,Messages.Listed);
        }

        public IResult Update(UpdateStatusRequest request)
        {
            Status status = _mapper.Map<Status>(request);
            _statusDal.Update(status);
            return new SuccessResult(Messages.Updated);
        }
    }
}
