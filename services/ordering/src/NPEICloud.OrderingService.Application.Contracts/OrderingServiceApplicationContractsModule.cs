using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace NPEICloud.OrderingService;

[DependsOn(
    typeof(OrderingServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
)]
public class OrderingServiceApplicationContractsModule : AbpModule
{

}