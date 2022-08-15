using SrBatata.Data.Models;

namespace SrBatata.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public bool Add(TEntity entity);

        public IEnumerable<TEntity> GetAll();
    }
}
