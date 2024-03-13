using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.Shared.Models.Services.CategoryService
{
    public interface ICategoryService
    {
        public HttpClient client { get; set; }

        public Task<CategoryApiModel> GetCategoryInclude(int id);

        public Task<List<CategoryApiModel>> GetAllCategoriesAsync();

        public Task<CategoryApiModel> GetCategoryByIdAsync(int id);

        public Task PostCategory(CategoryViewModel category);

        public Task DeleteCategory(int id);

        public Task UpdateCategoryAsync(int id, CategoryViewModel updatedCategory);
    }
}
