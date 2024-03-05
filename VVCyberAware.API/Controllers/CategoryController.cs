using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<CategoryModel> _categoryRepo;

        public List<CategoryModel> Categories { get; set; } = new()
        {

        };

        public CategoryController(ApplicationDbContext context, GenericRepository<CategoryModel> categoryRepo)
        {
            _context = context;
            _categoryRepo = categoryRepo;
        }

        [HttpGet("Category/{id}")]
        public ActionResult<CategoryModel> GetSingleCategory(int id)
        {
            var category = Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpGet("Categories")]
        public ActionResult<List<CategoryModel>> GetAllCategories()
        {
            return Ok(Categories);
        }



        [HttpPost("Category")]
        public ActionResult PostCategory(CategoryModel newCategory)
        {
            if (newCategory == null)
            {
                return BadRequest();
            }

            Categories.Add(newCategory);

            _categoryRepo.Add(newCategory);
            _context.SaveChanges();

            return Ok(newCategory);
        }

        [HttpDelete("Category/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var category = Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NoContent();
            }

            Categories.Remove(category);

            _categoryRepo.Delete(category.Id);
            _context.SaveChanges();

            return Ok(category);
        }

    }
}
