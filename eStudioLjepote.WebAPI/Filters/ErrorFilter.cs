using eStudioLjepote.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Filters
{
    public class ErrorFilter:ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if(context.Exception is UserException)
            {
                context.ModelState.AddModelError("Error", context.Exception.Message);
                context.HttpContext.Response.StatusCode =(int) HttpStatusCode.BadRequest;
            }
            else
            {
                context.ModelState.AddModelError("Error", "Greska na serveru");
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            context.Result = new JsonResult(context.ModelState);

        }
    }
}
