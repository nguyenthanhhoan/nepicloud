using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace NPEICloud.PublicWeb.Components.Purchase;

public class PurchaseWidgetStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/components/purchase/purchase-widget.css");
    }
}