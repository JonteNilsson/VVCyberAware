using Microsoft.EntityFrameworkCore;
using VVCyberAware.Data;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Database.Repositories
{
    public class CategoryIncludeRepo
    {
        private readonly ApplicationDbContext _context;

        public CategoryIncludeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryApiModel> GetCategoryInclude(int id)
        {
            var category = await _context.Categories
                .Where(c => c.Id == id)
                .Include(segment => segment.Segments!)
                .ThenInclude(subC => subC.SubCategories!)
                .ThenInclude(q => q.Questions)
                .FirstOrDefaultAsync();


            if (category != null)
            {
                var categoryApiModel = new CategoryApiModel
                {
                    Id = category.Id,
                    Name = category.Name,


                    Segments = category.Segments?.Select(seg => new SegmentApiModel
                    {
                        Id = seg.Id,
                        Name = seg.Name,
                        CategoryId = seg.CategoryId,
                        UserIsComplete = seg.UserIsComplete,

                        SubCategories = seg.SubCategories?.Select(subC => new SubCategoryApiModel
                        {
                            Id = subC.Id,
                            Description = subC.Description,
                            SegmentId = subC.SegmentId,
                            Questions = subC.Questions?.Select(q => new QuestionApiModel
                            {
                                Id = q.Id,
                                Answers = q.Answers,
                                Explanation = q.Explanation,
                                SubCategoryId = q.SubCategoryId,
                                QuestionText = q.QuestionText,

                            }).ToList()
                        }).ToList()
                    }).ToList()
                };

                return categoryApiModel;
            }

            return null!;

        }
    }
}
