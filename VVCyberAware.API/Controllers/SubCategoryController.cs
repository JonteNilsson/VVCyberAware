using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{
    public class SubCategoryController : Controller
    {
        public List<SubCategoryModel> SubCategories { get; set; } = new()
        {

        };


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

        [HttpGet("SubCategories")]
        public ActionResult<List<SubCategoryModel>> GetSubCategories()
        {
            return Ok(SubCategories);
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
            return Ok(subCategory);
        }
    }
}
