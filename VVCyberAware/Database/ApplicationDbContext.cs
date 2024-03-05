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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<CategoryModel>().HasData(
            //    new CategoryModel
            //    {
            //        Id = 1,
            //        Name = "Kreditkortsbedr�geri",
            //        Description = "Beskrivning f�r Kreditkortsbedr�geri",
            //        Segments = new List<SegmentModel> { new SegmentModel
            //        {
            //            Id = 1,
            //            Name = "Del 1",
            //            SubCategories = new List<SubCategoryModel>
            //            {
            //                new SubCategoryModel
            //                {
            //                    Id = 1,
            //                    Description = "Hejsan detta �r n�gonting",
            //                    Questions = new List<QuestionModel>
            //                    {
            //                        new QuestionModel
            //                        {
            //                            Id = 1,
            //                            YesorNo = false,
            //                            Description = "Detta �r en description"
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //      }
            //    });
            //    new SegmentModel
            //    {
            //        Id = 2,
            //        Name = "Del 2"
            //    }}

            //},
            //new CategoryModel
            //{
            //    Id = 2,
            //    Name = "Romansbedr�geri",
            //    Description = "Beskrivning f�r Romansbedr�geri"
            //});



        }
    }
}

