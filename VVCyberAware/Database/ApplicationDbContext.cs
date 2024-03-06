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


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Att skydda sig mot bedrägerier",
                    Description = "Info om bedrägeri"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Cybersäkerhet för företag",
                    Description = "Digital säkerhet på företag"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = " Cyberspionage",
                    Description = "Allmänt om cyberspionage"
                });



            modelBuilder.Entity<SegmentModel>().HasData(
                new SegmentModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 5,
                    CategoryId = 2,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 6,
                    CategoryId = 2,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 7,
                    CategoryId = 2,
                    Name = "Del 4",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 8,
                    CategoryId = 3,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 9,
                    CategoryId = 3,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 10,
                    CategoryId = 3,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                });


            modelBuilder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Description = "",
                    SegmentId = 1,

                });

            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    QuestionText = "",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A), Ett legitimt försök från banken att skydda ditt konto", false }
                    },
                    SubCategoryId = 1,

                });
        }
    }
}

