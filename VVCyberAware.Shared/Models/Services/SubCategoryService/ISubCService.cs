using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.SubCategoryService
{
    public interface ISubCService
    {
        public HttpClient client { get; set; }

        public Task<List<SubCategoryApiModel>> GetSubCategoriesAsync();

        public Task<SubCategoryApiModel> GetSubCategoryByIdAsync(int id);

        public Task PostSubCategory(SubCategoryApiModel subCategory);

        public Task DeleteSubCategory(int id);

        public Task UpdateSubCategoryAsync(int id, SubCategoryApiModel updatedSubCategory);
    }
}
