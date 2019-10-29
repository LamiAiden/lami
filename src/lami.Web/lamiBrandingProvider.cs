using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace lami.Web
{
    [Dependency(ReplaceServices = true)]
    public class lamiBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "lami";
    }
}
