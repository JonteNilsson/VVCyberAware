using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.Shared.Models.Services.SubCategoryService
{
    public interface ISubCService
    {
        public HttpClient client { get; set; }

        public Task<List<SubCategoryApiModel>> GetSubCategoriesAsync();

        public Task<SubCategoryApiModel> GetSubCategoryByIdAsync(int id);

        public Task PostSubCategory(SubCategoryViewModel subCategory);

        public Task DeleteSubCategory(int id);

        public Task UpdateSubCategoryAsync(int id, SubCategoryViewModel updatedSubCategory);
    }
}
