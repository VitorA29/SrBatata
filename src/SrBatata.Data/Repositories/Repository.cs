using Microsoft.EntityFrameworkCore;
using SrBatata.Data.Models;
using SrBatata.Data.Repositories;

namespace SrBatata.Abstractions.Storage
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected DbSet<TEntity> _dbSet;
        protected DbContext _dbContext;

        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual bool Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return _dbContext.SaveChanges() == 1;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
