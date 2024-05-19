using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace WebApp.Services
{

    public class AuthorizeCookieAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Проверяем наличие токена в куках
            if (!context.HttpContext.Request.Cookies.ContainsKey("token"))
            {
                
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "SignIn", action = "Index" }));
            }

            base.OnActionExecuting(context);
        }
    }
}