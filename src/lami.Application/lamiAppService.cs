using System;
using System.Collections.Generic;
using System.Text;
using lami.Localization;
using Volo.Abp.Application.Services;

namespace lami
{
    /* Inherit your application services from this class.
     */
    public abstract class lamiAppService : ApplicationService
    {
        protected lamiAppService()
        {
            LocalizationResource = typeof(lamiResource);
        }
    }
}
