using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.ApiModels
{
	public class QuestionApiModel
	{
		public int Id { get; set; }

		public string QuestionText { get; set; } = null!;

		public Dictionary<string, bool> Answers { get; set; } = new();

		public string? Explanation { get; set; }

		public SubCategoryModel? SubCategory { get; set; }

		public int SubCategoryId { get; set; }
	}
}
