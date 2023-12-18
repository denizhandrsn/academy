using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Requests.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _categoryService.GetAll();
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPost("add")]
        public IActionResult Post(CreateCategoryRequest request)
        {
            var result = _categoryService.Add(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(DeleteCategoryRequest request)
        {
            var result = _categoryService.Delete(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }
        [HttpPut("update")]
        public IActionResult Update(UpdateCategoryRequest request)
        {
            var result = _categoryService.Update(request);
            return StatusCode(result.Success ? 200 : 400, result);
        }


    }
}
