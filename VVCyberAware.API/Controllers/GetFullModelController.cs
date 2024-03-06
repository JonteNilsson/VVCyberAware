using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetFullModelController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<CategoryModel> _categoryRepo;

        public GetFullModelController(ApplicationDbContext context, GenericRepository<CategoryModel> categoryRepo)
        {
            _context = context;
            _categoryRepo = categoryRepo;
        }

        [HttpGet("GetFullModel/{id}")]
        public async Task<ActionResult<CategoryModel>> GetModelIncluding(int id)
        {
            // Assuming _categoryRepo returns an IQueryable<CategoryModel>
            CategoryModel? fullModel = await _categoryRepo
                .GetFirstOrDefaultInclude(c => c.Id == id, "Segments.SubCategories.Questions");

            if (fullModel == null)
            {
                return NotFound();
            }

            return fullModel;
        }
    }
}
