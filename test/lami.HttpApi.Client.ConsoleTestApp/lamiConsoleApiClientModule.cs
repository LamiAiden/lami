using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace lami.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(lamiHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class lamiConsoleApiClientModule : AbpModule
    {
        
    }
}
