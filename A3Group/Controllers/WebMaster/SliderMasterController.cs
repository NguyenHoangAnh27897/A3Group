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
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
				var lst = db.A3Group_Sliders.Find(1);
				return View(lst);
		}

        [Authorize(Roles = "Admin")]
        [HttpPost]
		public JsonResult Edit(A3Group_Sliders sli)
		{
			string msg = "";
			try
			{
				var home = db.A3Group_Sliders.Find(1);
				home.Title = sli.Title;
				home.Slogan = sli.Slogan;
				home.Description = sli.Description;
				home.Video = sli.Video;
				db.Entry(home).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				msg = "Lưu thành công";
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