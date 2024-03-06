namespace VVCyberAware.Shared.Models.ApiModels
{
    public class QuestionApiModel
    {
        public int Id { get; set; }

        public string? QuestionText { get; set; }

        public Dictionary<string, bool> Answers { get; set; } = new();

        public string? Explanation { get; set; }

        public SubCategoryApiModel? SubCategory { get; set; }

        public int SubCategoryId { get; set; }
    }
}
