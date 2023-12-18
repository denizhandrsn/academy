using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _applicationService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateApplicationRequest request)
        {
            var result = _applicationService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteApplicationRequest request)
        {
            var result = _applicationService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateApplicationRequest request)
        {
            var result = _applicationService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
