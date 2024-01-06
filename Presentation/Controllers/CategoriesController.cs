using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CategoriesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync() =>
            Ok(await _manager.CategoryService.GetAllCategoriesAsync(false));

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCategoryAsync([FromRoute(Name = "id")] int id) =>
            Ok(await _manager.CategoryService.GetOneCategoryByIdAsync(id, false));

        [HttpPost]
        public async Task<IActionResult> CreateOneCategoryAsync([FromBody] CategoryDtoForInsertion categoryDto)
        {
            var category = await _manager.CategoryService.CreateOneCategoryAsync(categoryDto);
            return StatusCode(201, category);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneCategoryAsync([FromRoute(Name = "id")] int id, [FromBody] CategoryDtoForUpdate categoryDto)
        {
            await _manager.CategoryService.UpdateOneCategoryAsync(id, categoryDto, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneCategoryAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.CategoryService.DeleteOneCategoryAsync(id, false);
            return NoContent();
        }
    }
}