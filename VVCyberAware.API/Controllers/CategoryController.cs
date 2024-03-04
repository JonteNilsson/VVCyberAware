using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{
    public class CategoryController : Controller
    {

        public List<CategoryModel> Categories { get; set; } = new()
        {

        };

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
            return Ok(category);
        }

    }
}
