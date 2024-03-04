using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VVCyberAware.Shared.Models.DbModels
{
	public class QuestionModel
	{
		[Key]
		public int Id { get; set; }

		public string Description { get; set; } = null!;

		public bool YesorNo { get; set; }
	}
}