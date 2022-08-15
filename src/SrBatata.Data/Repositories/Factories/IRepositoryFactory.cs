using SrBatata.Abstractions.Storage;
using SrBatata.Data.Models;

namespace SrBatata.Data.Repositories.Factories
{
    public interface IRepositoryFactory : IDisposable
    {
        public Repository<TEntity> GetRepository<TEntity>(Type type) where TEntity : Entity;

        public int Commit();
    }
}
