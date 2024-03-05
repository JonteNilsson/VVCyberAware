using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.SubCategoryService
{
    public class SubCService : ISubCService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7214/api/")
        };

        public async Task<List<SubCategoryModel>> GetSubCategoriesAsync()
        {
            var response = await client.GetAsync("SubCategory/SubCategories");

            if (response.IsSuccessStatusCode)
            {
                string subCJson = await response.Content.ReadAsStringAsync();

                List<SubCategoryModel>? subCategories = JsonConvert.DeserializeObject<List<SubCategoryModel>>(subCJson);

                if (subCategories != null)
                {
                    return subCategories;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<SubCategoryModel> GetSubCategoryByIdAsync(int id)
        {
            var response = await client.GetAsync($"SubCategory/{id}");

            if (response.IsSuccessStatusCode)
            {
                string subCJson = await response.Content.ReadAsStringAsync();

                SubCategoryModel? subCategory = JsonConvert.DeserializeObject<SubCategoryModel>(subCJson);

                if (subCategory != null)
                {
                    return subCategory;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostSubCategory(SubCategoryModel subCategory)
        {
            await client.PostAsJsonAsync("SubCategory/Post", subCategory);
        }
    }
}
