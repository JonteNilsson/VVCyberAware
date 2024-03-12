using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }


        /// <summary>
        /// Takes an API Model and maps it to a ViewModel making it easier to use in the UI
        /// </summary>
        /// <param name="apiModel"></param>
        /// <returns>Returns a viewmodel</returns>
        public static CategoryViewModel MapToViewModel(CategoryApiModel apiModel)
        {
            return new CategoryViewModel
            {
                Name = apiModel.Name,
                Description = apiModel.Description,
                Id = apiModel.Id,
            };
        }


    }
}
