using Volo.Abp.Modularity;

namespace NPEICloud.OrderingService
{
    [DependsOn(
        typeof(OrderingServiceApplicationModule),
        typeof(OrderingServiceDomainTestModule)
        )]
    public class OrderingServiceApplicationTestModule : AbpModule
    {

    }
}
