using Microsoft.EntityFrameworkCore;
using SrBatata.Abstractions.Storage;
using SrBatata.Data.Models;

namespace SrBatata.Data.Repositories.Factories
{
    internal class RepositoryFactory : IRepositoryFactory
    {
        private readonly DbContext _context;
        public RepositoryFactory(DbContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Repository<TEntity> GetRepository<TEntity>(Type type) where TEntity : Entity
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
