using lami.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace lami.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(lamiEntityFrameworkCoreDbMigrationsModule),
        typeof(lamiApplicationContractsModule)
        )]
    public class lamiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
