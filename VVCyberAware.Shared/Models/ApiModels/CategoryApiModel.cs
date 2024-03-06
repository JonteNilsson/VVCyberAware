using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.ApiModels
{
	public class CategoryApiModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public List<SegmentModel>? Segments { get; set; }

	}
}
