using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VVCyberAware.Data;

namespace VVCyberAware.Database.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetModelById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T? entityToDelete = GetModelById(id);

            if (entityToDelete != null)
            {
                _dbSet.Remove(entityToDelete);
            }
        }

        public void Update(T entity)
        {
            // Attach the entity to the _context if it's not already being tracked
            if (!_dbSet.Local.Any(e => e.Equals(entity)))
            {
                _dbSet.Attach(entity);
            }

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        ///// <summary>
        ///// Send argument as a string for example "Table1.Table2" to include Main content Table, Table1 and Table2 in it.
        ///// If you want only one include send only one string of the table name.
        ///// </summary>
        ///// <param name="navigationProperties"></param>
        ///// <returns>List of all <typeparamref name="T"/> in a table with all other specified tables included</returns>
        //public async Task<List<T>?> GetAllInclude(params string[] navigationProperties)
        //{

        //    IQueryable<T> query = _dbSet;   //Set to Queryable to build onto the LINQ method so it will be include().include().... until all sent in are included
        //                                    //Almost as a string builder

        //    foreach (var navigationProperty in navigationProperties)
        //    {
        //        query = query.Include(navigationProperty); // Build the query
        //    }

        //    return await query.ToListAsync(); //Execute and make it to a list
        //}

        public async Task<T?> GetFirstOrDefaultInclude(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        {
            IQueryable<T> query = _dbSet;

            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            // Apply the predicate to filter the result
            query = query.Where(predicate);


            // Use FirstOrDefault to get the first or default result
            return await query.FirstOrDefaultAsync();
        }

        //public CategoryApiModel CategoryMapAPIModel(CategoryModel categoryModel)
        //{
        //    CategoryApiModel mappedModel = categoryModel
        //}
    }
}
