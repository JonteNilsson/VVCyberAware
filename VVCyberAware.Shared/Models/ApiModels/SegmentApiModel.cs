namespace VVCyberAware.Shared.Models.ApiModels
{
    public class SegmentApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<SubCategoryApiModel>? SubCategories { get; set; }

        public CategoryApiModel? Category { get; set; }
        public int CategoryId { get; set; }

        public List<string>? UserIsComplete { get; set; }
    }
}
