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
		a3groupEntities1 db = new a3groupEntities1();
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

		[HttpPost]
		public ActionResult Edit(string maintitle, string maindes, string title1, string title2, string title3, string title4, string des1, string des2, string des3, string des4)
		{
			//if (Session["Authentication"] != null)
			//{
			var home = db.A3Group_Differences.Find(1);
			home.MainDescription = maindes;
			home.MainTitle = maintitle;
			home.SubTitle1 = title1;
			home.SubTitle2 = title2;
			home.SubTitle3 = title3;
			home.SubTitle4 = title4;
			home.SubDescription1 = des1;
			home.SubDescription2 = des2;
			home.SubDescription3 = des3;
			home.SubDescription4 = des4;
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