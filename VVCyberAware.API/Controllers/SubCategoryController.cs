using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<SubCategoryModel> _subCRepo;

        public SubCategoryController(ApplicationDbContext context, GenericRepository<SubCategoryModel> subCRepo)
        {
            _context = context;
            _subCRepo = subCRepo;
        }

        [HttpGet("SubCategories")]
        public async Task<ActionResult<List<SubCategoryModel>>> GetSubCategories()
        {
            var subCategories = await _subCRepo.GetAll();

            if (subCategories != null)
            {
                return Ok(subCategories);
            }

            return BadRequest();
        }


        [HttpGet("SubCategory/{id}")]
        public async Task<ActionResult<SubCategoryModel>> GetSingleSubCategory(int id)
        {
            var subCategory = await _subCRepo.GetModelById(id);

            if (subCategory == null)
            {
                return NotFound();
            }

            return Ok(subCategory);
        }


        [HttpPost("PostSubCategory")]
        public async Task<ActionResult> PostSubCategory(SubCategoryViewModel newSubCategory)
        {
            if (newSubCategory == null)
            {
                return BadRequest();
            }

            SubCategoryModel model = new()
            {
                Description = newSubCategory.Description!,
                SegmentId = newSubCategory.SegmentId,

            };

            await _subCRepo.Add(model);

            return Ok(newSubCategory);
        }

        [HttpDelete("DeleteSubCategory/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var subCategory = await _subCRepo.GetModelById(id);

            if (subCategory == null)
            {
                return NotFound();
            }

            await _subCRepo.Delete(subCategory.Id);

            _context.SaveChanges();

            return Ok(subCategory);
        }


        [HttpPut("UpdateSubCategory/{id}")]
        public async Task<IActionResult> UpdateSubCategory(int id, [FromBody] SubCategoryViewModel updatedSubCategory)
        {
            if (id != updatedSubCategory.Id)
            {
                return BadRequest("ID's do not match");
            }

            var existingSubCategory = await _context.SubCategories
                .FirstOrDefaultAsync(sc => sc.Id == id);

            if (existingSubCategory == null)
            {
                return NotFound($"SubCategory with ID {id} not found");
            }

            existingSubCategory.Id = updatedSubCategory.Id;
            existingSubCategory.SegmentId = updatedSubCategory.SegmentId;
            existingSubCategory.Description = updatedSubCategory.Description!;

            _subCRepo.Update(existingSubCategory);

            try
            {
                await _context.SaveChangesAsync();
                return Ok($"SubCategory with ID {id} updated successfully");
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Concurrency error occurred");
            }
        }


    }
}
