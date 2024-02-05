using Business.Requests.Courses;
using Business.Responses.Courses;


namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<ListCourseResponse>> GetAll();
        IResult Add(CreateCourseRequest request);
        IResult Update(UpdateCourseRequest request);
        IResult Delete(DeleteCourseRequest request);
        IDataResult<GetCourseResponse> GetById(GetCourseRequest request);
        IDataResult<List<ListCourseResponse>> GetAllByCategory(int categoryId);
    }
}
