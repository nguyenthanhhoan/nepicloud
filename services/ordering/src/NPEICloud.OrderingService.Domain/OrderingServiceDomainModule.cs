using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace NPEICloud.OrderingService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrderingServiceDomainSharedModule)
)]
public class OrderingServiceDomainModule : AbpModule
{

}