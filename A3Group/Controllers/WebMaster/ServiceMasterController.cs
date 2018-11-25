using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class ServiceMasterController : Controller
    {
        a3groupEntities1 db = new a3groupEntities1();
        // GET: Service
        public ActionResult Edit()
        {
            //if (Session["Authentication"] != null)
            //{
            var lst = db.A3Group_Services.Find(1);
            return View(lst);
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}

        }

        [HttpPost]
        public ActionResult Edit(string maintitle, string maindes, string title1, string title2, string title3, string title4, string title5, string title6, string des1, string des2, string des3, string des4, string des5, string des6)
        {
            //if (Session["Authentication"] != null)
            //{
            var home = db.A3Group_Services.Find(1);
            home.MainTitle = maintitle;
            home.MainDescription = maindes;
            home.SubTitle1 = title1;
            home.SubDescription1 = des1;
            home.SubTitle2 = title2;
            home.SubDescription2 = des2;
            home.SubTitle3 = title3;
            home.SubDescription3 = des3;
            home.SubTitle4 = title4;
            home.SubDescription4 = des4;
            home.SubTitle5 = title5;
            home.SubDescription5 = des5;
            home.SubTitle6 = title6;
            home.SubDescription6 = des6;
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