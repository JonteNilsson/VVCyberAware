using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<CategoryModel> Categories { get; set; }
		public DbSet<SegmentModel> Segments { get; set; }
		public DbSet<SubCategoryModel> SubCategories { get; set; }
		public DbSet<QuestionModel> Questions { get; set; }


	}
}
