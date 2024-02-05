using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Categories;
using Business.Responses.Categories;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        IMapper _mapper;
        ICategoryDal _categoryDal;

        public CategoryManager(IMapper mapper, ICategoryDal categoryDal)
        {
            _mapper = mapper;
            _categoryDal = categoryDal;
        }

        public IResult Add(CreateCategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            _categoryDal.Add(category);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(DeleteCategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ListCategoryResponse>> GetAll()
        {
            List<Category> categories = _categoryDal.GetAll();
            List<ListCategoryResponse> response = _mapper.Map<List<ListCategoryResponse>>(categories);
            return new SuccessDataResult<List<ListCategoryResponse>>(response,Messages.Listed);
        }

        public IResult Update(UpdateCategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Updated);
        }
    }
}
