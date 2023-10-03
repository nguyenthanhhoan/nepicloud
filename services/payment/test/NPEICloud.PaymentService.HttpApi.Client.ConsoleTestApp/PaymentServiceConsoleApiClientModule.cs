using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace NPEICloud.PaymentService
{
    [DependsOn(
        typeof(PaymentServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PaymentServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
