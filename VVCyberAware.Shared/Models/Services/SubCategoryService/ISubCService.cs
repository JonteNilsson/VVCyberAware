using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.SubCategoryService
{
    public interface ISubCService
    {
        public HttpClient client { get; set; }

        public Task<List<SubCategoryModel>> GetSubCategoriesAsync();

        public Task<SubCategoryModel> GetSubCategoryByIdAsync(int id);

        public Task PostSubCategory(SubCategoryModel subCategory);
    }
}
