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
        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(string maintitle, string maindes, string title1, string title2, string title3, string des1, string des2, string des3, string price1, string price2, string price3)
        {
            //if (Session["Authentication"] != null)
            //{
            var home = db.A3Group_Prices.Find(1);
            home.MainTitle = maintitle;
            home.MainDescription = maindes;
            home.SubTitle1 = title1;
            home.Prices1 = int.Parse(price1);
            home.Description1 = des1;
            home.SubTitle2 = title2;
            home.Prices2 = int.Parse(price2);
            home.Description2 = des2;
            home.SubTitle3 = title3;
            home.Prices3 = int.Parse(price3);
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