using NPEICloud.IdentityService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NPEICloud.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceEntityFrameworkCoreTestModule)
        )]
    public class IdentityServiceDomainTestModule : AbpModule
    {

    }
}