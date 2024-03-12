using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VVCyberAware.Shared.Models.DbModels
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; } = null!;

        [NotMapped]
        public Dictionary<string, bool> Answers { get; set; } = new();

        [Column(TypeName = "jsonb")] // Specify the JSON column type
        public string AnswersJson
        {
            get => System.Text.Json.JsonSerializer.Serialize(Answers);
            set => Answers = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, bool>>(value)!;
        }

        public string? Explanation { get; set; }

        public SubCategoryModel? SubCategory { get; set; } // Nav prop

        public int SubCategoryId { get; set; }
    }
}