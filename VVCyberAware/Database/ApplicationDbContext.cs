using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                // Define the primary key for IdentityUserToken<string>
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                // Definiera primärnyckeln för IdentityUserLogin<string>
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                // Define the primary key for IdentityUserRole<string>
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Bedrägeri",
                    Description = "Info om bedrägeri"
                });


            modelBuilder.Entity<SegmentModel>().HasData(
                new SegmentModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Del 1",
                    UserId = new List<string>()
                });

            modelBuilder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Description = "Something",
                    SegmentId = 1,

                });

            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    QuestionText = "Vad är din favorit färg?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A), Ett legitimt försök från banken att skydda ditt konto", false }
                    },
                    SubCategoryId = 1,

                });




        }
    }
}

