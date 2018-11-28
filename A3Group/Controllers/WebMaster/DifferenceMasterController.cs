using System;
using System.Collections.Generic;
using System.IO;
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
		public JsonResult Edit(A3Group_Differences diff)
		{
			string message = "";
			try 
			{
				var home = db.A3Group_Differences.Find(1);
				home.MainDescription = diff.MainDescription;
				home.MainTitle = diff.MainTitle;
				home.SubTitle1 = diff.SubTitle1;
				home.SubDescription1 = diff.SubDescription1;
				home.SubTitle2 = diff.SubTitle2;
				home.SubDescription2 = diff.SubDescription2;
				home.SubTitle3 = diff.SubTitle3;
				home.SubDescription3 = diff.SubDescription3;
				home.SubTitle4 = diff.SubTitle4;
				home.SubDescription4 = diff.SubDescription4;
                home.BoldText = diff.BoldText;
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

        [HttpPost]
        public ActionResult Upload1(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageDifference");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                var home = db.A3Group_Differences.Find(1);
                if (name != "")
                {
                    home.Image1 = name;
                }
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Content("chunk uploaded", "text/plain");
        }

        [HttpPost]
        public ActionResult Upload2(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageDifference");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                var home = db.A3Group_Differences.Find(1);
                if (name != "")
                {
                    home.Image2 = name;
                }
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Content("chunk uploaded", "text/plain");
        }

        [HttpPost]
        public ActionResult Upload3(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageDifference");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                var home = db.A3Group_Differences.Find(1);
                if (name != "")
                {
                    home.Image3 = name;
                }
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Content("chunk uploaded", "text/plain");
        }

        [HttpPost]
        public ActionResult Upload4(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageDifference");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                var home = db.A3Group_Differences.Find(1);
                if (name != "")
                {
                    home.Image4 = name;
                }
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Content("chunk uploaded", "text/plain");
        }
    }
}