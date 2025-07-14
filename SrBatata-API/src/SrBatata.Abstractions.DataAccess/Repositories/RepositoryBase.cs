using Microsoft.EntityFrameworkCore;
using SrBatata.Abstractions.DataAccess.Models;

namespace SrBatata.Abstractions.DataAccess.Repositories
{
    public abstract class RepositoryBase<TEntity, TContext> : IRepository<TEntity> where TEntity : Entity where TContext : DbContext
    {
        protected DbSet<TEntity> _dbSet;
        protected TContext _dbContext;

        protected RepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
