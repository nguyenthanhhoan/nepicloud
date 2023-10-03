using NPEICloud.PublicWeb.Components.Basket;
using NPEICloud.PublicWeb.Components.Toolbar.Cart;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace NPEICloud.PublicWeb.Controllers;

[Route("Widgets")]
public class WidgetsController : AbpController
{
    [HttpGet]
    [Route("Basket")]
    public IActionResult Counters()
    {
        return ViewComponent(typeof(BasketWidgetViewComponent));
    }

    [HttpGet]
    [Route("Cart")]
    public IActionResult GetCartWidget()
    {
        return ViewComponent(typeof(CartWidgetViewComponent));
    }
}