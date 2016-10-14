using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWP.Controllers
{
    public class CheckAuthorizeController : Controller
    {
        // GET: CheckAurhorize
        public ActionResult UnAuthorize()
        {
            return View();
        }
    }
}