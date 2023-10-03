using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace NPEICloud.OrderingService
{
    [DependsOn(
        typeof(OrderingServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderingServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
