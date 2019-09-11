using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Infra
{
    public class GlobalExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = 500;
            //context.Result = new ViewResult { ViewName = "/Errors/E500" };
            context.Result = new RedirectToActionResult("E500", "Errors", null);
        }
    }
}
