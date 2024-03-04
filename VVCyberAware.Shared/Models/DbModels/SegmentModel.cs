using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCyberAware.Shared.Models.DbModels
{
	public class SegmentModel
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public List<SubCategoryModel>? SubCategory { get; set; }
	}

}
