using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7214/api/")
        };

        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var response = await client.GetAsync("Category/Categories");

            if (response.IsSuccessStatusCode)
            {
                string categoryJson = await response.Content.ReadAsStringAsync();

                List<CategoryModel>? categories = JsonConvert.DeserializeObject<List<CategoryModel>>(categoryJson);

                if (categories != null)
                {
                    return categories;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<CategoryModel> GetCategoryByIdAsync(int id)
        {
            var response = await client.GetAsync($"Category/{id}");

            if (response.IsSuccessStatusCode)
            {
                string categoryJson = await response.Content.ReadAsStringAsync();

                CategoryModel? category = JsonConvert.DeserializeObject<CategoryModel>(categoryJson);

                if (category != null)
                {
                    return category;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostCategory(CategoryModel category)
        {
            await client.PostAsJsonAsync("Category/Post", category);
        }
    }
}
