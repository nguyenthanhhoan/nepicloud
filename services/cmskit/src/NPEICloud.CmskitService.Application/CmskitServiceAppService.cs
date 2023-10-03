using NPEICloud.CmskitService.Localization;
using Volo.Abp.Application.Services;

namespace NPEICloud.CmskitService;

public abstract class CmskitServiceAppService : ApplicationService
{
    protected CmskitServiceAppService()
    {
        LocalizationResource = typeof(CmskitServiceResource);
        ObjectMapperContext = typeof(CmskitServiceApplicationModule);
    }
}
