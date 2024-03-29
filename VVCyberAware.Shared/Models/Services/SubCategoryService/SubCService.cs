﻿using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

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
            var response = await client.GetAsync($"SubCategory/SubCategory/{id}");

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
        public async Task PostSubCategory(SubCategoryViewModel subCategory)
        {
            await client.PostAsJsonAsync("SubCategory/PostSubCategory", subCategory);
        }

        /// <summary>
        /// Updates the model sent in to the method
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCategory"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>

        public async Task UpdateSubCategoryAsync(int id, SubCategoryViewModel updatedSubCategory)
        {
            // Convert the updatedSubCategory to JSON
            string updatedSubCategoryJson = JsonConvert.SerializeObject(updatedSubCategory);

            // Create a StringContent with the JSON data
            var content = new StringContent(updatedSubCategoryJson, Encoding.UTF8, "application/json");

            // Make the PUT request
            var response = await client.PutAsync($"SubCategory/UpdateSubCategory/{id}", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException();
            }
        }

        /// <summary>
        /// Deletes chosen model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteSubCategory(int id)
        {
            await client.DeleteAsync($"SubCategory/DeleteSubCategory/{id}");
        }

    }
}
