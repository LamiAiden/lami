using lami.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace lami.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class lamiController : AbpController
    {
        protected lamiController()
        {
            LocalizationResource = typeof(lamiResource);
        }
    }
}