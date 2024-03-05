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

        public string? Explanation { get; set; }

        public SubCategoryModel? SubCategory { get; set; } // Nav prop

        public int SubCategoryId { get; set; }
    }
}