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
            var lst = db.A3Group_Prices.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Edit(A3Group_Prices pri)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Prices.Find(1);
                home.MainTitle = pri.MainTitle;
                home.MainDescription = pri.MainDescription;
                home.SubTitle1 = pri.SubTitle1;
                home.Prices1 = pri.Prices1;
                pri.Description1 = pri.Description1.Substring(0, 2) + " class='mb-10px text-left'" + pri.Description1.Substring(2);
                pri.Description1 = pri.Description1.Substring(0, 29) + "<i class='fa fa-check color-orange text-center radius-50'></i>" + pri.Description1.Substring(29);
                home.Description1 = pri.Description1;
                home.SubTitle2 = pri.SubTitle2;
                home.Prices2 = pri.Prices2;
                pri.Description2 = pri.Description2.Substring(0, 2) + " class='mb-10px text-left'" + pri.Description2.Substring(2);
                pri.Description2 = pri.Description2.Substring(0, 29) + "<i class='fa fa-check color-orange text center radius-50'></i>" + pri.Description2.Substring(29);
                home.Description2 = pri.Description2;
                home.SubTitle3 = pri.SubTitle3;
                home.Prices3 = pri.Prices3;
                home.BoldText = pri.BoldText;
                pri.Description3 = pri.Description3.Substring(0, 2) + " class='mb-10px text-left'" + pri.Description3.Substring(2);
                pri.Description3 = pri.Description3.Substring(0, 29) + "<i class='fa fa-check color-orange text-center radius-50'></i>" + pri.Description3.Substring(29);
                home.Description3 = pri.Description3;
                home.Unit1 = pri.Unit1;
                home.Unit2 = pri.Unit2;
                home.Unit3 = pri.Unit3;
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                msg = "Chỉnh sửa thành công";
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
