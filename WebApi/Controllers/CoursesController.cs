using Business.Abstracts;
using Business.Concretes;
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
        [HttpPost("add")]
        public IActionResult Post(CreateCourseRequest request) 
        {
            var result = _courseService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
