using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCyberAware.Shared.Models.ApiModels
{
	public class SubCategoryModel
	{
		public int Id { get; set; }

		public string Description { get; set; } = null!;

		public SegmentModel? Segment { get; set; } // Nav prop
		public int SegmentId { get; set; }

	}
}
