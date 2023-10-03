using NPEICloud.CatalogService.MongoDB;
using Volo.Abp.Modularity;

namespace NPEICloud.CatalogService
{
    [DependsOn(
        typeof(CatalogServiceMongoDbTestModule)
        )]
    public class CatalogServiceDomainTestModule : AbpModule
    {

    }
}