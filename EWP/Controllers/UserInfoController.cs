using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EWP.Models;
using System.Web.Security;
using System.Net;

namespace EWP.Controllers
{
    public class UserInfoController : Controller
    {
        EWPEntities db = new EWPEntities();
        // GET: UserInfo
        public ActionResult Index(Guid userID)
        {
            var userInfo = db.GetUserByUserID((Guid)Membership.GetUser(User.Identity.Name).ProviderUserKey);
            if (userInfo != null)
            {
                return View(userInfo);
            }
            return Create();
        }

        // GET: UserInfo/Details/5
        public ActionResult Details(int id)
        {
            var userInfo = db.GetUserByUserID((Guid)Membership.GetUser(User.Identity.Name).ProviderUserKey);
            if (userInfo != null)
            {
                return View(userInfo);
            }
            return Create();
        }

        // GET: UserInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserInfo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserInfo/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EWPUser user = db.EWPUsers.Find(id);
            //if (user == null)
            //{
            //    return HttpNotFound();
            //}
            if (user != null)
            {
                ViewBag.SportID = new SelectList(db.Sports, "SportID", "SportName", user.SportID);//new SelectList(db.Sports, "SportID", "SportName", userInfo.SportID);
                ViewBag.GenderID = new SelectList(GenderList(), "GenderName", user.Gender);
            }
            else
            {
                ViewBag.SportID = new SelectList(db.Sports, "SportID", "SportName");                
                ViewBag.GenderList = GenderList();
                
            }

            return View(user);
        }

        // POST: UserInfo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                ViewBag.SportID = new SelectList(db.Sports, "SportID", "SportName");
                ViewBag.GenderList = GenderList();
                // TODO: Add update logic here
                EWPUser myUser = db.EWPUsers.Find(id);
                if (myUser == null)
                {
                    myUser.UserID = (Guid)id;
                    myUser.FirstName = collection["FirstName"];
                    myUser.LastName = collection["LastName"];
                    myUser.Gender = collection["Gender"];
                    myUser.DateOfBirth = Convert.ToDateTime(collection["DateOfBirth"]);
                    myUser.Username = collection["Username"];
                    myUser.Height = Convert.ToInt32(collection["Height"]);
                    myUser.Experience = Convert.ToInt32(collection["Experience"]);
                    myUser.SportID = Convert.ToInt32(collection["SportID"]);
                    myUser.PhoneNumber = collection["PhoneNumber"];
                    myUser.Address = collection["Address"];

                    db.SaveChanges();
                }
                else
                {
                    UpdateModel(myUser, "myUser");
                }
                
                //myUser.save();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: UserInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        /// <summary>
        /// Description:
        ///     Populating the gender dropdown
        /// History:
        ///     Amir Naji   19-10-2016
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GenderList()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Value = "Male", Text = "Male" });
            items.Add(new SelectListItem() { Value = "Female", Text = "Female" });
            return items;
        }

        public SelectList GetAllSports()
        {
            return new SelectList(db.GetAllSports(), "SportID", "SportName");
        }
    }
}
