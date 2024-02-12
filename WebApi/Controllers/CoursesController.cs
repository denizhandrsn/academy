using Business.Abstracts;
using Business.Concretes;
using Business.Requests.Applicants;
using Business.Requests.Courses;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _courseService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        {
            //var result = _courseService.get
            return StatusCode(400);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateCourseRequest request)
        {
            var result = _courseService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteCourseRequest request)
        {
            var result = _courseService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateCourseRequest request)
        {
            var result = _courseService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }

    }
}
