using eCommerce.Shared.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eCommerce.Web.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!Request.Cookies.ContainsKey(SD.AnonymousId))
            {
                var id = Guid.NewGuid().ToString(); 
                Response.Cookies.Append(SD.AnonymousId, id, new CookieOptions
                {
                    Expires = DateTime.UtcNow.AddDays(30)
                });
            }
            base.OnActionExecuting(context);
        }
    }
}
