using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class SliderMasterController : Controller
    {
		a3groupEntities db = new a3groupEntities();
        // GET: SliderMaster
        public ActionResult Edit()
        {
			//if (Session["Authentication"] != null)
			//{
				var lst = db.A3Group_Sliders.Find(1);
				return View(lst);
			//}
			//else
			//{
			//	return RedirectToAction("Login", "Account");
			//}
		}

		[HttpPost]
		public ActionResult Edit(string title, string slogan, string description, string video)
		{
			//if(Session["Authentication"] != null)
			//{
				var home = db.A3Group_Sliders.Find(1);
				home.Title = title;
				home.Slogan = slogan;
				home.Description = description;
				home.Video = video;
				db.Entry(home).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Edit", "SliderMaster");
			//}
			//else
			//{
			//	return RedirectToAction("Login", "Account");
			//}
		}
    }
}