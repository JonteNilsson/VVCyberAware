using System.ComponentModel.DataAnnotations;

namespace VVCyberAware.Shared.Models.DbModels
{
	public class SegmentModel
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public List<SubCategoryModel>? SubCategories { get; set; }

		public List<string> UserId { get; set; }
	}

}
