using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NPEICloud.Shared.Hosting.AspNetCore
{
    [Dependency(ReplaceServices = true)]
    public class NPEICloudBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "NPEICloud";
    }
}
