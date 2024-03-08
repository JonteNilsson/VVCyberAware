using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.ViewModels
{
    public class QuestionViewModel
    {
        public string? QuestionText { get; set; }

        public Dictionary<string, bool> Answers { get; set; } = new();

        public string? Explanation { get; set; }

        public int SubCategoryId { get; set; }


        /// <summary>
        /// Takes an API Model and maps it to a ViewModel making it easier to use in the UI
        /// </summary>
        /// <param name="apiModel"></param>
        /// <returns>Returns a viewmodel</returns>
        public static QuestionViewModel MapTiViewModel(QuestionApiModel apiModel)
        {
            return new QuestionViewModel
            {
                QuestionText = apiModel.QuestionText,
                Answers = apiModel.Answers,
                Explanation = apiModel.Explanation,
                SubCategoryId = apiModel.SubCategoryId

            };
        }

    }
}
