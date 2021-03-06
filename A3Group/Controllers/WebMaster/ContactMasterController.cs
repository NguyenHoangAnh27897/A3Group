﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class ContactMasterController : Controller
    {
        a3groupEntities db = new a3groupEntities();
        // GET: ContactMaster
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
            var lst = db.A3Group_Information.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Edit(A3Group_Information info)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Information.Find(1);
                home.Title = info.Title;
                home.Description = info.Description;
                home.Address = info.Address;
                home.Phone = info.Phone;
                home.Email = info.Email;
                home.BoldText = info.BoldText;
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                msg = "Chỉnh sửa thành công";
                return Json(new { Message = msg });
            }
            catch (Exception ex)
            {
                msg = "Lưu không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditSlogan()
        {
            var lst = db.A3Group_Quotes.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult EditSlogan(A3Group_Quotes qu)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Quotes.Find(1);
                home.Quote = qu.Quote;
                home.Name = qu.Name;
                home.Roles = qu.Roles;
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                msg = "Chỉnh sửa thành công";
                return Json(new { Message = msg });
            }
            catch (Exception ex)
            {
                msg = "Lưu không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }
        }
    }
}