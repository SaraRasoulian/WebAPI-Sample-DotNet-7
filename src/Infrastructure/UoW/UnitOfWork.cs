using Application.Interfaces;
using Domain.Interfaces;
using Infrastructure.DbContexts;
using Infrastructure.Repositories;

namespace Infrastructure.UoW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        public IEducationRepository Education { get; private set; }

        private readonly SampleDbContext _dbContext;
        public UnitOfWork(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
            Education = new EducationRepository(_dbContext);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _dbContext.DisposeAsync();
        }
    }
}
