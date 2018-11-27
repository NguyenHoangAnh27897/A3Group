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
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
		{
			var lst = db.A3Group_Differences.Find(1);
			return View(lst);
		}

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateInput(false)]
		public ActionResult Edit(A3Group_Differences diff)
		{
			string message = "";
			try 
			{
				var home = db.A3Group_Differences.Find(1);
				home.MainDescription = diff.MainDescription;
				home.MainTitle = diff.MainTitle;
				home.SubTitle1 = diff.SubTitle1;
				home.SubTitle2 = diff.SubTitle2;
				home.SubTitle3 = diff.SubTitle3;
				home.SubTitle4 = diff.SubTitle4;
				home.SubDescription1 = diff.SubDescription1;
				home.SubDescription2 = diff.SubDescription2;
				home.SubDescription3 = diff.SubDescription3;
				home.SubDescription4 = diff.SubDescription4;
				db.Entry(home).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				message = "Chỉnh sửa thành công!";
				return Json(new { Message = message });

			}
			catch (Exception)
			{
				message = "Chỉnh sửa không thành công, vui lòng kiểm tra lại";
				return Json(new { Message = message });
			}
			
		}
	}
}