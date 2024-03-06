using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.DbModels;

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
        public ActionResult<List<CategoryModel>> GetAllCategories()
        {
            var categories = _categoryRepo.GetAll();

            if (categories != null)
            {
                return Ok(categories);
            }

            return BadRequest();
        }



        [HttpGet("Category/{id}")]
        public ActionResult<CategoryModel> GetSingleCategory(int id)
        {
            var category = _categoryRepo.GetModelById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

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


        [HttpPost("Category")]
        public ActionResult PostCategory(CategoryModel newCategory)
        {
            if (newCategory == null)
            {
                return BadRequest();
            }

            _categoryRepo.Add(newCategory);
            _context.SaveChanges();

            return Ok(newCategory);
        }

        [HttpDelete("Category/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var category = _categoryRepo.GetModelById(id);

            if (category == null)
            {
                return NoContent();
            }


            _categoryRepo.Delete(category.Id);
            _context.SaveChanges();

            return Ok(category);
        }


        [HttpPut("Category/{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryModel updatedCategory)
        {
            // Validate the input
            if (id != updatedCategory.Id)
            {
                return BadRequest("ID's does not match");
            }

            // Try to find the existing category
            var existingCategory = await _context.Categories
                .Include(c => c.Segments) // Include related entities if necessary
                .FirstOrDefaultAsync(c => c.Id == id);

            // Check if the category exists
            if (existingCategory == null)
            {
                return NotFound($"Category with ID {id} not found");
            }

            // Update properties of the existing category
            existingCategory.Id = updatedCategory.Id;
            existingCategory.Name = updatedCategory.Name;
            existingCategory.Description = updatedCategory.Description;


            _categoryRepo.Update(existingCategory);

            // Save changes to the database
            try
            {
                await _context.SaveChangesAsync();
                return Ok($"Category with ID {id} updated successfully");
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency issues if needed
                return StatusCode(500, "Concurrency error occurred");
            }
        }
    }



}

