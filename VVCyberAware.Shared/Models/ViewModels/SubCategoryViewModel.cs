using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.ViewModels
{
    public class SubCategoryViewModel
    {

        public int Id { get; set; }
        public string? Description { get; set; }

        public int SegmentId { get; set; }



        /// <summary>
        /// Takes an API Model and maps it to a ViewModel making it easier to use in the UI
        /// </summary>
        /// <param name="apiModel"></param>
        /// <returns>Returns a viewmodel</returns>
        public static SubCategoryViewModel MapToViewModel(SubCategoryApiModel apiModel)
        {
            return new SubCategoryViewModel
            {
                Description = apiModel.Description,
                SegmentId = apiModel.SegmentId,
                Id = apiModel.Id
            };
        }
    }
}
