using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.Instructors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;
        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _instructorService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateInstructorRequest request)
        {
            var result = _instructorService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteInstructorRequest request)
        {
            var result = _instructorService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateInstructorRequest request)
        {
            var result = _instructorService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }

    }
}
