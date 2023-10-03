using Volo.Abp.Modularity;

namespace NPEICloud.PaymentService
{
    [DependsOn(
        typeof(PaymentServiceApplicationModule),
        typeof(PaymentServiceDomainTestModule)
        )]
    public class PaymentServiceApplicationTestModule : AbpModule
    {

    }
}
