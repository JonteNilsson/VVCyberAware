using System.ComponentModel.DataAnnotations;

namespace VVCyberAware.Shared.Models.DbModels
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<SegmentModel>? Segments { get; set; }

    }
}
