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
    }
}