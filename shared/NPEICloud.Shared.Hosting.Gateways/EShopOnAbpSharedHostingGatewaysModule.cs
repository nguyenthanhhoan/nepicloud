using NPEICloud.Shared.Hosting.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace NPEICloud.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(NPEICloudSharedHostingAspNetCoreModule)
    )]
    public class NPEICloudSharedHostingGatewaysModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            
            context.Services.AddReverseProxy()
                .LoadFromConfig(configuration.GetSection("ReverseProxy"));
        }
    }
}