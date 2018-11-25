using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class PriceMasterController : Controller
    {
        a3groupEntities db = new a3groupEntities();
        // GET: PriceMaster
        public ActionResult Edit()
        {
            //if (Session["Authentication"] != null)
            //{
            var lst = db.A3Group_Prices.Find(1);
            return View(lst);
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }

        [HttpPost]
        public ActionResult Edit(string maintitle, string maindes, string title1, string title2, string title3, string des1, string des2, string des3, string price1, string price2, string price3)
        {
            //if (Session["Authentication"] != null)
            //{
            var home = db.A3Group_Prices.Find(1);
            home.MainTitle = maintitle;
            home.MainDescription = maindes;
            home.Title1 = title1;
            home.Price1 = int.Parse(price1);
            home.Description1 = des1;
            home.Title2 = title2;
            home.Price2 = int.Parse(price2);
            home.Description2 = des2;
            home.Title3 = title3;
            home.Price3 = int.Parse(price3);
            home.Description3 = des3;
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