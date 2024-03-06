namespace VVCyberAware.Shared.Models.ApiModels
{
    public class CategoryApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<SegmentApiModel>? Segments { get; set; }

    }
}
