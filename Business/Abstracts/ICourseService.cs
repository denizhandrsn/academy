using Business.Requests.Courses;
using Business.Responses.Courses;


namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<ListCourseResponse>> GetAll();
        IResult Add(CreateCourseRequest request);
        IResult Update(UpdateCourseRequest request);
        IDataResult<List<Course>> GetAllByCategory(int categoryId);
        IDataResult<List<Course>> GetAllByPriceRange(decimal min,decimal max);

    }
}
