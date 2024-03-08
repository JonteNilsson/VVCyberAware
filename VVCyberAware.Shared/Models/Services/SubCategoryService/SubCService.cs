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

        /// <summary>
        /// Make an API call to get all Subcategories
        /// </summary>
        /// <returns>Returns a list of Subcategories</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
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

        /// <summary>
        /// Makes an API call looking for a specific Segment with its inputted ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Segment matching the ID</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
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

        /// <summary>
        /// Posts a Segment and stores it in Database
        /// </summary>
        /// <param name="subCategory"></param>
        /// <returns></returns>
        public async Task PostSubCategory(SubCategoryApiModel subCategory)
        {
            await client.PostAsJsonAsync("SubCategory/Post", subCategory);
        }
    }
}
