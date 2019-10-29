using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace lami.Data
{
    /* This is used if database provider does't define
     * IlamiDbSchemaMigrator implementation.
     */
    public class NulllamiDbSchemaMigrator : IlamiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}