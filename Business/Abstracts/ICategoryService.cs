using Business.Requests.Categories;
using Business.Requests.Courses;
using Business.Responses.Categories;
using Business.Responses.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IDataResult<List<ListCategoryResponse>> GetAll();
        IResult Add(CreateCategoryRequest request);
        IResult Update(UpdateCategoryRequest request);
        IResult Delete(DeleteCategoryRequest request);
    }
}
