﻿using NPEICloud.PaymentService.Localization;
using Volo.Abp.Application.Services;

namespace NPEICloud.PaymentService
{
    public abstract class PaymentServiceAppService : ApplicationService
    {
        protected PaymentServiceAppService()
        {
            LocalizationResource = typeof(PaymentServiceResource);
            ObjectMapperContext = typeof(PaymentServiceApplicationModule);
        }
    }
}
