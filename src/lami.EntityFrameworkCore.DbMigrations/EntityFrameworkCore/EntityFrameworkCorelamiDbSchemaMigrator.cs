using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lami.Data;
using Volo.Abp.DependencyInjection;

namespace lami.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCorelamiDbSchemaMigrator 
        : IlamiDbSchemaMigrator, ITransientDependency
    {
        private readonly lamiMigrationsDbContext _dbContext;

        public EntityFrameworkCorelamiDbSchemaMigrator(lamiMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}