using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.CategoryService
{
    public interface ICategoryService
    {
        public HttpClient client { get; set; }

        public Task<List<CategoryModel>> GetCategoriesAsync();

        public Task<CategoryModel> GetCategoryByIdAsync(int id);

        public Task PostCategory(CategoryModel category);
    }
}
