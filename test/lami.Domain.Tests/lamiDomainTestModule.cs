using lami.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace lami
{
    [DependsOn(
        typeof(lamiEntityFrameworkCoreTestModule)
        )]
    public class lamiDomainTestModule : AbpModule
    {

    }
}