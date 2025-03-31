using SrBatata.Abstractions.DataAccess.Models;

namespace SrBatata.Abstractions.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public TEntity Add(TEntity entity);

        public IEnumerable<TEntity> GetAll();

        public void SaveChanges();
    }
}
