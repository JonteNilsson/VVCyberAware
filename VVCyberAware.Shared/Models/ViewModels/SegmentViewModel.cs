using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.ViewModels
{
    public class SegmentViewModel
    {
        public string? Name { get; set; }
        public List<string>? UserIsComplete { get; set; }



        /// <summary>
        /// Takes an API Model and maps it to a ViewModel making it easier to use in the UI
        /// </summary>
        /// <param name="apiModel"></param>
        /// <returns>Returns a viewmodel</returns>
        public static SegmentViewModel MapToViewModel(SegmentApiModel apiModel)
        {
            return new SegmentViewModel
            {
                Name = apiModel.Name,
                UserIsComplete = apiModel.UserIsComplete,
            };
        }
    }
}
