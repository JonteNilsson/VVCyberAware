using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.DbModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<CategoryModel> _categoryRepo;
        private readonly CategoryIncludeRepo _includeRepo;

        public CategoryController(ApplicationDbContext context, GenericRepository<CategoryModel> categoryRepo, CategoryIncludeRepo includeRepo)
        {
            _context = context;
            _categoryRepo = categoryRepo;
            _includeRepo = includeRepo;
        }


        [HttpGet("Categories")]
        public async Task<ActionResult<List<CategoryApiModel>>> GetAllCategories()
        {
            var categories = await _categoryRepo.GetAll();

            if (categories != null)
            {
                return Ok(categories);
            }

            return BadRequest();
        }



        [HttpGet("Category/{id}")]
        public async Task<ActionResult<CategoryApiModel>> GetSingleCategory(int id)
        {
            var category = await _categoryRepo.GetModelById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        /// <summary>
        /// Includes the whole branch with Category,Segment,Subcategory and Questions
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A model containing everything</returns>
        [HttpGet("CategoryInclude/{id}")]
        public async Task<ActionResult<CategoryApiModel>> GetCategoryInclude(int id)
        {
            var category = await _includeRepo.GetCategoryInclude(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }



        [HttpPost("PostCategory")]
        public async Task<ActionResult> PostCategory(CategoryViewModel newCategory)
        {
            if (newCategory == null)
            {
                return BadRequest();
            }

            CategoryModel model = new()
            {
                Description = newCategory.Description!,
                Name = newCategory.Name!

            };

            await _categoryRepo.Add(model);
            _context.SaveChanges();

            return Ok(newCategory);
        }


        [HttpDelete("DeleteCategory/{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var category = await _categoryRepo.GetModelById(id);

            if (category == null)
            {
                return NoContent();
            }

            await _categoryRepo.Delete(category.Id);

            return Ok(category);
        }


        [HttpPut("UpdateCategory/{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryViewModel updatedCategory)
        {
            // Validate the input
            if (id != updatedCategory.Id)
            {
                return BadRequest("ID's does not match");
            }


            var existingCategory = await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == id);

            if (existingCategory == null)
            {
                return NotFound($"Category with ID {id} not found");
            }


            existingCategory.Id = updatedCategory.Id;
            existingCategory.Name = updatedCategory.Name!;
            existingCategory.Description = updatedCategory.Description!;


            _categoryRepo.Update(existingCategory);

            try
            {
                await _context.SaveChangesAsync();
                return Ok($"Category with ID {id} updated successfully");
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Concurrency error occurred");
            }
        }
    }



}

