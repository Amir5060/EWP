using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View(/*new Models.HomeViewModel { CurrerntUserID = User.Identity.GetUserId() }*/);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult GetUserIDForView()
        //{
        //    return this.View(new Models.HomeViewModel { CurrerntUserID = User.Identity.GetUserId() });
        //}
    }
}