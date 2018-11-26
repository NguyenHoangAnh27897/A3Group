using System;
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
        public ActionResult Edit()
        {
            //if (Session["Authentication"] != null)
            //{
            var lst = db.A3Group_Information.Find(1);
            return View(lst);
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }

        [HttpPost]
        public ActionResult Edit(string maintitle, string maindes, string address, string phone, string email)
        {
            //if (Session["Authentication"] != null)
            //{
            var home = db.A3Group_Information.Find(1);
            home.Title = maintitle;
            home.Description = maindes;
            home.Address = address;
            home.Phone = phone;
            home.Email = email;
            db.Entry(home).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Edit");
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }

        public ActionResult EditSlogan()
        {
            //if (Session["Authentication"] != null)
            //{
            var lst = db.A3Group_Quotes.Find(1);
            return View(lst);
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }

        [HttpPost]
        public ActionResult EditSlogan(string slogan, string name, string role)
        {
            //if (Session["Authentication"] != null)
            //{
            var home = db.A3Group_Quotes.Find(1);
            home.Quote = slogan;
            home.Name = name;
            home.Roles = role;
            db.Entry(home).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Edit");
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }
    }
}