using lami.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace lami.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class lamiPageModel : AbpPageModel
    {
        protected lamiPageModel()
        {
            LocalizationResourceType = typeof(lamiResource);
        }
    }
}