using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace lami.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<lamiWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
