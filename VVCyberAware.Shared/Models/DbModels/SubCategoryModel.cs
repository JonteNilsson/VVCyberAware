using System.ComponentModel.DataAnnotations;

namespace VVCyberAware.Shared.Models.DbModels
{
    public class SubCategoryModel
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; } = null!;

        public SegmentModel? Segment { get; set; } // Nav prop
        public int SegmentId { get; set; }

        public List<QuestionModel>? Questions { get; set; }

    }
}
