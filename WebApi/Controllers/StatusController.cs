using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.Statuses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _statusService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateStatusRequest request)
        {
            var result = _statusService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteStatusRequest request)
        {
            var result = _statusService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateStatusRequest request)
        {
            var result = _statusService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }



    }
}
