﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EWP.Models;
using System.Web.Security;

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
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
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

        public SelectList GetAllSports()
        {
            return new SelectList(db.GetAllSports(), "SportID", "SportName");
        }
    }
}
