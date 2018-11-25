using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class DifferenceMasterController : Controller
    {
        a3groupEntities db = new a3groupEntities();
        // GET: DifferenceMaster
        public ActionResult Edit()
        {
            //if (Session["Authentication"] != null)
            //{
            var lst = db.A3Group_Differences.Find(1);
            return View(lst);
            //}
            //else
            //{
            //	return RedirectToAction("Login", "Account");
            //}
        }
    }
}