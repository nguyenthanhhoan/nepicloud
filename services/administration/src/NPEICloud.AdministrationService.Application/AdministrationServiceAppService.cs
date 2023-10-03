using System;
using System.Collections.Generic;
using System.Text;
using NPEICloud.AdministrationService.Localization;
using Volo.Abp.Application.Services;

namespace NPEICloud.AdministrationService
{
    /* Inherit your application services from this class.
     */
    public abstract class AdministrationServiceAppService : ApplicationService
    {
        protected AdministrationServiceAppService()
        {
            LocalizationResource = typeof(AdministrationServiceResource);
        }
    }
}
