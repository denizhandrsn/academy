using Business.Abstracts;
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

        [HttpGet]
        public IActionResult Get() 
        {
            var result = _instructorService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }


        [HttpPost]
        public IActionResult Post(CreateInstructorRequest request)
        {
            var result = _instructorService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }

    }
}
