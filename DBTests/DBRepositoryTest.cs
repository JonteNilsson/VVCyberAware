using Microsoft.EntityFrameworkCore;
using Moq;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

namespace DBTests
{
    public class DBRepositoryTest
    {

        [Fact]
        public async Task AddCategoryTest()
        {
            // ------------- Setup -------------

            // Create a mock (Copy that is used for only testing) of the ApplicationDbContext class
            var mockDbContext = new Mock<ApplicationDbContext>();

            // Create a mock DbSet for the CategoryModel class
            var mockDbSet = new Mock<DbSet<CategoryModel>>();

            // Set up the mock DbContext to return the mock DbSet when its Set method is called, (Used to not get a Null reference when executing Verify checks)
            mockDbContext.Setup(m => m.Set<CategoryModel>()).Returns(mockDbSet.Object);

            // Create an instance of the GenericRepository using the mocked DbContext
            var repo = new GenericRepository<CategoryModel>(mockDbContext.Object);
            var entityToAdd = new CategoryModel
            {
                Name = "TestCategory",
                Description = "This is the best category for tests!",
                Segments = new List<SegmentModel> { }
            };

            // ------------- Act -------------

            // Perform the action being tested: add the entity to the repository (And from there to the Database)
            await repo.Add(entityToAdd);

            // ------------- Assert -------------

            // Verify that the AddAsync method of the mock DbSet was called once with the provided entity and CancellationToken.None
            // ...Token.None is used because it is an "optional" argument and as we do not use tokens and Verify needs all optional arguments
            // We need to provide the argument, but as we dont have a token ...Token.None makes sense to use here
            mockDbSet.Verify(m => m.AddAsync(entityToAdd, CancellationToken.None), Times.Once);

            // Verify that the SaveChangesAsync method of the mock DbContext was called once with CancellationToken.None
            mockDbContext.Verify(m => m.SaveChangesAsync(CancellationToken.None), Times.Once);
        }


        //[Fact]
        //public async Task AddSegmentTest()
        //{
        //    var segmentToAdd = new SegmentModel
        //    {
        //        Name = "TestSegment",
        //        SubCategories = new List<SubCategoryModel> { },
        //        CategoryId = 1,
        //        UserIsComplete = new List<string> { }
        //    };
        //    await AddModelTest<SegmentModel>(segmentToAdd);
        //}


        // Johannes
        // Instansiering av olika typer av modeller, lägga till temporära properties och skickar den till metod som prövar att lägga till det i en mock databas
        [Theory]
        [InlineData("TestSegment", typeof(SegmentModel))]
        [InlineData("TestCategory", typeof(CategoryModel))]
        [InlineData("TestSubCategory", typeof(SubCategoryModel))]
        [InlineData("TestQuestion", typeof(QuestionModel))]
        public async Task AddModelTests(string modelName, Type modelType)
        {
            var modelToAdd = Activator.CreateInstance(modelType);
            // You may need to cast modelToAdd to TModel depending on your requirements

            // Set properties specific to each model type
            if (modelType == typeof(SegmentModel))
            {
                var segment = modelToAdd as SegmentModel;
                segment.Name = modelName;
                segment.CategoryId = 1;
                segment.SubCategories = new List<SubCategoryModel>();
                segment.UserIsComplete = new List<string>();
                // Set other properties for SegmentModel
            }
            else if (modelType == typeof(CategoryModel))
            {
                var category = modelToAdd as CategoryModel;
                category.Name = modelName;
                category.Segments = new List<SegmentModel>();
                category.Description = $"This is a test {modelName}";
                // Set other properties for CategoryModel
            }
            else if (modelType == typeof(SubCategoryModel))
            {
                var subCategory = modelToAdd as SubCategoryModel;
                subCategory.Description = $"This is a {modelName}";
                subCategory.Questions = new List<QuestionModel>();
                subCategory.SegmentId = 1;

            }
            else if (modelType == typeof(QuestionModel))
            {
                var question = modelToAdd as QuestionModel;
                question.QuestionText = $"This is a {modelName}";
                question.Answers = new Dictionary<string, bool>();
                question.Explanation = "This explains its just a test";
            }

            await AddModelTest(modelToAdd);
        }

        // Johannes
        // Generisk metod som tar emot en entity och försöker lägga till det i en mockdatabase
        private async Task AddModelTest<TModel>(TModel modelToAdd) where TModel : class
        {
            // Arrange
            var mockDbContext = new Mock<ApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<TModel>>();
            mockDbContext.Setup(m => m.Set<TModel>()).Returns(mockDbSet.Object);
            var mockRepo = new GenericRepository<TModel>(mockDbContext.Object);

            // Act
            await mockRepo.Add(modelToAdd);

            // Assert
            mockDbSet.Verify(m => m.AddAsync(modelToAdd, CancellationToken.None), Times.Once);
            mockDbContext.Verify(m => m.SaveChangesAsync(CancellationToken.None), Times.Once);
        }

    }
}