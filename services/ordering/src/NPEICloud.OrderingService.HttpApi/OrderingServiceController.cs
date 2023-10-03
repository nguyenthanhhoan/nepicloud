using NPEICloud.OrderingService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NPEICloud.OrderingService;

public abstract class OrderingServiceController : AbpControllerBase
{
    protected OrderingServiceController()
    {
        LocalizationResource = typeof(OrderingServiceResource);
    }
}