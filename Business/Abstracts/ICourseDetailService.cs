using Business.Requests.CourseDetails;
using Business.Requests.Courses;
using Business.Responses.CourseDetails;
using Business.Responses.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseDetailService
    {
        IDataResult<List<ListCourseDetailResponse>> GetAll();
        IDataResult<CourseDetail> Add(CreateCourseDetailRequest request);
        IResult Update(UpdateCourseDetailRequest request);
        IResult Delete(DeleteCourseDetailRequest request);
    }
}
