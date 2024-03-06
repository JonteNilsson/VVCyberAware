using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.ApiModels
{
    public class SubCategoryApiModel
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public SegmentModel? Segment { get; set; } // Nav prop

        public List<QuestionApiModel>? Questions { get; set; }
        public int SegmentId { get; set; }

    }
}
