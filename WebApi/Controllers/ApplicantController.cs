using Business.Abstracts;
using Business.Requests.Applicants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        IApplicantService _applicantService;
        public ApplicantController(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _applicantService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateApplicantRequest request)
        {
            var result = _applicantService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
