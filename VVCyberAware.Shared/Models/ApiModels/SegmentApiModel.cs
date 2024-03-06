using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.ApiModels
{
	public class SegmentModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public List<SubCategoryModel>? SubCategories { get; set; }

		public CategoryModel? Category { get; set; }
		public int CategoryId { get; set; }

		public List<string>? UserIsComplete { get; set; }
	}
}
