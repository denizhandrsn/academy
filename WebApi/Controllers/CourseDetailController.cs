using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.CourseDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailController : ControllerBase
    {
        ICourseDetailService _courseDetailService;

        public CourseDetailController(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _courseDetailService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateCourseDetailRequest request)
        {
            var result = _courseDetailService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteCourseDetailRequest request)
        {
            var result = _courseDetailService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateCourseDetailRequest request)
        {
            var result = _courseDetailService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
