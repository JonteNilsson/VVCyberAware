using Microsoft.EntityFrameworkCore;
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
            // Attach the entity to the context if it's not already being tracked
            if (!_dbSet.Local.Any(e => e.Equals(entity)))
            {
                _dbSet.Attach(entity);
            }

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
