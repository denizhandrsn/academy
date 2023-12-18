using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.Users;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _userService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateUserRequest request)
        {
            var result = _userService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteUserRequest request)
        {
            var result = _userService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateUserRequest request)
        {
            var result = _userService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
    }
}
