using Volo.Abp.Modularity;

namespace lami
{
    [DependsOn(
        typeof(lamiApplicationModule),
        typeof(lamiDomainTestModule)
        )]
    public class lamiApplicationTestModule : AbpModule
    {

    }
}