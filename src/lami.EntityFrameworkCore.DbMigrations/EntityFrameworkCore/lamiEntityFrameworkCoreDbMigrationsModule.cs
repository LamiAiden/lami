using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace lami.EntityFrameworkCore
{
    [DependsOn(
        typeof(lamiEntityFrameworkCoreModule)
        )]
    public class lamiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<lamiMigrationsDbContext>();
        }
    }
}
