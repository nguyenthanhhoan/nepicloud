using NPEICloud.CmskitService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NPEICloud.CmskitService;

public abstract class CmskitServiceController : AbpControllerBase
{
    protected CmskitServiceController()
    {
        LocalizationResource = typeof(CmskitServiceResource);
    }
}
