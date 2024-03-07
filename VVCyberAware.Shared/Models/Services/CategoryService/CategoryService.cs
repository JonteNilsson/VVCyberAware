using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("http://localhost:5142/api/")
        };


        /// <summary>
        /// Makes an API call and includes every relevant model that is connected to the inputed category
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a model including Segments, Subcategories and Questions including Answers and the correct answer</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<CategoryApiModel> GetCategoryInclude(int id)
        {
            var response = await client.GetAsync($"Category/CategoryInclude/{id}");

            if (response.IsSuccessStatusCode)
            {
                string categoryIncludeJson = await response.Content.ReadAsStringAsync();

                CategoryApiModel? category = JsonConvert.DeserializeObject<CategoryApiModel>(categoryIncludeJson);

                if (category != null)
                {
                    return category;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<List<CategoryApiModel>> GetCategoriesAsync()
        {
            var response = await client.GetAsync("Category/Categories");

            if (response.IsSuccessStatusCode)
            {
                string categoryJson = await response.Content.ReadAsStringAsync();

                List<CategoryApiModel>? categories = JsonConvert.DeserializeObject<List<CategoryApiModel>>(categoryJson);

                if (categories != null)
                {
                    return categories;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<CategoryApiModel> GetCategoryByIdAsync(int id)
        {
            var response = await client.GetAsync($"Category/{id}");

            if (response.IsSuccessStatusCode)
            {
                string categoryJson = await response.Content.ReadAsStringAsync();

                CategoryApiModel? category = JsonConvert.DeserializeObject<CategoryApiModel>(categoryJson);

                if (category != null)
                {
                    return category;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostCategory(CategoryApiModel category)
        {
            await client.PostAsJsonAsync("Category/Post", category);
        }
    }
}
