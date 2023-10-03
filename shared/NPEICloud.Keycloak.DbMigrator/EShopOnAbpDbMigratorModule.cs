using NPEICloud.Shared.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace NPEICloud.DbMigrator;

[DependsOn(
    typeof(NPEICloudSharedHostingModule)
)]
public class NPEICloudDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<KeycloakClientOptions>(options =>
            {
                options.Url = configuration["Keycloak:url"];
                options.AdminUserName = configuration["Keycloak:adminUsername"];
                options.AdminPassword = configuration["Keycloak:adminPassword"];
                options.RealmName = configuration["Keycloak:realmName"];
            }
        );
    }
}