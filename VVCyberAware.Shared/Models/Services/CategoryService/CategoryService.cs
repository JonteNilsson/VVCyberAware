using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

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
		/// <summary>
		/// Make an API call to get all Categories
		/// </summary>
		/// <returns>Returns a list of Categories</returns>
		/// <exception cref="JsonException"></exception>
		/// <exception cref="HttpRequestException"></exception>
		public async Task<List<CategoryApiModel>> GetAllCategoriesAsync()
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
		/// <summary>
		/// Makes an API call looking for a specific Category with its inputted ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns>Returns the Category matching the ID</returns>
		/// <exception cref="JsonException"></exception>
		/// <exception cref="HttpRequestException"></exception>
		public async Task<CategoryApiModel> GetCategoryByIdAsync(int id)
		{
			var response = await client.GetAsync($"Category/Category/{id}");

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

		/// <summary>
		/// Posts a Category and stores it in Database
		/// </summary>
		/// <param name="category"></param>
		/// <returns></returns>
		public async Task PostCategory(CategoryApiModel category)
		{
			await client.PostAsJsonAsync("Category/PostCategory", category);
		}

		public async Task DeleteCategory(int id)
		{
			await client.DeleteAsync($"Category/DeleteCategory/{id}");
		}

		public async Task UpdateCategoryAsync(int id, CategoryViewModel updatedCategory)
		{
			// Convert the updatedCategory to JSON
			string updatedCategoryJson = JsonConvert.SerializeObject(updatedCategory);

			// Create a StringContent with the JSON data
			var content = new StringContent(updatedCategoryJson, Encoding.UTF8, "application/json");

			// Make the PUT request
			var response = await client.PutAsync($"Category/UpdateCategory/{id}", content);

			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException();

			}

		}

	}
}
