using NPEICloud.PaymentService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NPEICloud.PaymentService
{
    public abstract class PaymentServiceController : AbpControllerBase
    {
        protected PaymentServiceController()
        {
            LocalizationResource = typeof(PaymentServiceResource);
        }
    }
}
