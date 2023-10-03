using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NPEICloud.AuthServer.Pages
{
    public class IndexModel : AbpPageModel
    {
        public ActionResult OnGet()
        {
            if (!CurrentUser.IsAuthenticated)
            {
                return Redirect("~/Account/Login");
            }
            else
            {
                return Page();
            }
        }
    }
}
