using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.CategoryService
{
    public interface ICategoryService
    {
        public HttpClient client { get; set; }

        public Task<CategoryApiModel> GetCategoryInclude(int id);

        public Task<List<CategoryApiModel>> GetAllCategoriesAsync();

        public Task<CategoryApiModel> GetCategoryByIdAsync(int id);

        public Task PostCategory(CategoryApiModel category);
    }
}
