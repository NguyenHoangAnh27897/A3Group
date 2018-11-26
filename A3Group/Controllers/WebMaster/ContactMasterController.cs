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
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
            var lst = db.A3Group_Information.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(string maintitle, string maindes, string address, string phone, string email)
        {
            var home = db.A3Group_Information.Find(1);
            home.Title = maintitle;
            home.Description = maindes;
            home.Address = address;
            home.Phone = phone;
            home.Email = email;
            db.Entry(home).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Edit");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult EditSlogan()
        {
            var lst = db.A3Group_Quotes.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult EditSlogan(string slogan, string name, string role)
        {
            var home = db.A3Group_Quotes.Find(1);
            home.Quote = slogan;
            home.Name = name;
            home.Roles = role;
            db.Entry(home).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}