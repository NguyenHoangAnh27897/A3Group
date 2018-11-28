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
		a3groupEntities db = new a3groupEntities();
        // GET: Service
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
            var lst = db.A3Group_Services.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
		public JsonResult Edit(A3Group_Services ser)
        {
			string message = "";
			try
			{
				var home = db.A3Group_Services.Find(1);
				home.MainTitle = ser.MainTitle;
				home.MainDescription = ser.MainDescription;
				home.SubTitle1 = ser.SubTitle1;
				home.SubDescription1 = ser.SubDescription1;
				home.SubTitle2 = ser.SubTitle2;
				home.SubDescription2 = ser.SubDescription2;
				home.SubTitle3 = ser.SubTitle3;
				home.SubDescription3 = ser.SubDescription3;
				home.SubTitle4 = ser.SubTitle4;
				home.SubDescription4 = ser.SubDescription4;
				home.SubTitle5 = ser.SubTitle5;
				home.SubDescription5 = ser.SubDescription5;
				home.SubTitle6 = ser.SubTitle6;
				home.SubDescription6 = ser.SubDescription6;
                home.BoldText = ser.BoldText;
				db.Entry(home).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				message = "Chỉnh sửa thành công!";
				return Json(new { Message = message });
			}
			catch (Exception)
			{
				message = "Lưu không thành công, vui lòng kiểm tra lại";
				return Json(new { Message = message });
			}
        }
    }
}