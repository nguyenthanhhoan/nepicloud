using Volo.Abp.Modularity;

namespace NPEICloud.CmskitService;

[DependsOn(
    typeof(CmskitServiceApplicationModule),
    typeof(CmskitServiceDomainTestModule)
    )]
public class CmskitServiceApplicationTestModule : AbpModule
{

}
