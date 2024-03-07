using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.SubCategoryService
{
    public class SubCService : ISubCService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("http://localhost:5142/api/")
        };

        public async Task<List<SubCategoryApiModel>> GetSubCategoriesAsync()
        {
            var response = await client.GetAsync("SubCategory/SubCategories");

            if (response.IsSuccessStatusCode)
            {
                string subCJson = await response.Content.ReadAsStringAsync();

                List<SubCategoryApiModel>? subCategories = JsonConvert.DeserializeObject<List<SubCategoryApiModel>>(subCJson);

                if (subCategories != null)
                {
                    return subCategories;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<SubCategoryApiModel> GetSubCategoryByIdAsync(int id)
        {
            var response = await client.GetAsync($"SubCategory/{id}");

            if (response.IsSuccessStatusCode)
            {
                string subCJson = await response.Content.ReadAsStringAsync();

                SubCategoryApiModel? subCategory = JsonConvert.DeserializeObject<SubCategoryApiModel>(subCJson);

                if (subCategory != null)
                {
                    return subCategory;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostSubCategory(SubCategoryApiModel subCategory)
        {
            await client.PostAsJsonAsync("SubCategory/Post", subCategory);
        }
    }
}
