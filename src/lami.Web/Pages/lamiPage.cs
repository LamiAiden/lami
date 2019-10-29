using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using lami.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace lami.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits lami.Web.Pages.lamiPage
     */
    public abstract class lamiPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<lamiResource> L { get; set; }
    }
}
