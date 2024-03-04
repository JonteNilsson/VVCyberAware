using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVCyberAware.Shared.Models.DbModels
{
	public class SubCategoryModel
	{
		[Key]
		public int Id { get; set; }

		public string Description { get; set; } = null!;

		public List<QuestionModel>? Questions { get; set; }
	}
}
