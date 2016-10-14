using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWP.Class
{
    public class CustomAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //you can change to any controller or html page.
            filterContext.Result = new RedirectResult("Views/Roles/Unauthorize");

        }
    }
}