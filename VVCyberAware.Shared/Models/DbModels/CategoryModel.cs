using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCyberAware.Shared.Models.DbModels
{
	public class CategoryModel
	{
		[Key]
		public string Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public List<SegmentModel> Segment { get; set; }

	}
}
