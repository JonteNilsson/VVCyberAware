using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

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

        public List<SubCategoryModel> SubCategories { get; set; } = new()
        {

        };


        [HttpGet("SubCategories")]
        public ActionResult<List<SubCategoryModel>> GetSubCategories()
        {
            return Ok(SubCategories);
        }




        [HttpGet("SubCategory/{id}")]
        public ActionResult<SubCategoryModel> GetSingleSubCategory(int id)
        {
            var subCategory = SubCategories.FirstOrDefault(sc => sc.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            return Ok(subCategory);

        }


        [HttpPost("SubCategory")]
        public ActionResult PostSubCategory(SubCategoryModel newSubCategory)
        {
            if (newSubCategory == null)
            {
                return BadRequest();
            }

            SubCategories.Add(newSubCategory);

            _subCRepo.Add(newSubCategory);

            _context.SaveChanges();

            return Ok(newSubCategory);
        }




        [HttpDelete("SubCategory/{id}")]
        public ActionResult Delete(int id)
        {
            var subCategory = SubCategories.FirstOrDefault(c => c.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            SubCategories.Remove(subCategory);

            _subCRepo.Delete(subCategory.Id);

            _context.SaveChanges();

            return Ok(subCategory);
        }
    }
}
