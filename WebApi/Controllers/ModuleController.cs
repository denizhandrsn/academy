using Business.Abstracts;
using Business.Requests.Modules;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        IModuleService _moduleService;

        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _moduleService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost]
        public IActionResult Post(CreateModuleRequest request)
        {
            var result = _moduleService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }

    }
}
