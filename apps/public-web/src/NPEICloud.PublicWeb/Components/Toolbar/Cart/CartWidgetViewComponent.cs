﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using NPEICloud.PublicWeb.ServiceProviders;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;

namespace NPEICloud.PublicWeb.Components.Toolbar.Cart;

[Widget(
    AutoInitialize = true,
    RefreshUrl = "/Widgets/Cart",
    StyleTypes = new[] {typeof(CartWidgetStyleContributor)},
    ScriptTypes = new[] {typeof(CartWidgetScriptContributor)}
)]
public class CartWidgetViewComponent : AbpViewComponent
{
    private readonly UserBasketProvider _userBasketProvider;

    public CartWidgetViewComponent(UserBasketProvider userBasketProvider)
    {
        _userBasketProvider = userBasketProvider;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(
            "~/Components/Toolbar/Cart/Default.cshtml",
            await _userBasketProvider.GetBasketAsync());
    }
}