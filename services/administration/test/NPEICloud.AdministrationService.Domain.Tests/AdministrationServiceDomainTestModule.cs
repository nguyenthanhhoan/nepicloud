using NPEICloud.AdministrationService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NPEICloud.AdministrationService
{
    [DependsOn(
        typeof(AdministrationServiceEntityFrameworkCoreTestModule)
        )]
    public class AdministrationServiceDomainTestModule : AbpModule
    {

    }
}