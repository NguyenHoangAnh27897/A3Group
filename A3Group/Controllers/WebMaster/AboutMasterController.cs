using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers.WebMaster
{
    public class AboutMasterController : Controller
    {
		a3groupEntities db = new a3groupEntities();
        // GET: AboutMaster
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {
			var lst = db.A3Group_About.Find(1);
			return View(lst);
		}

        [Authorize(Roles = "Admin")]
        [HttpPost]
		public ActionResult Edit(string maintitle, string maindes, string title1, string title2, string title3, string title4, string des1, string des2, string des3, string des4)
		{
			var home = db.A3Group_About.Find(1);
			home.MainTitle = maintitle;
			home.MainDescription = maindes;
			home.SubDescription1 = des1;
			home.SubDescription2 = des2;
			home.SubDescription3 = des3;
			home.SubDescription4 = des4;
			home.SubTitle1 = title1;
			home.SubTitle2 = title2;
			home.SubTitle3 = title3;
			home.SubTitle4 = title4;
			db.Entry(home).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Edit");
		}

        [Authorize(Roles = "Admin")]
        public ActionResult EditIntroduce()
        {
            var lst = db.A3Group_Features.Find(1);
            return View(lst);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult EditIntroduce(A3Group_Features feat)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Features.Find(1);
                home.MainTitle = feat.MainTitle;
                home.MainDescription = feat.MainDescription;
                home.SubTitle = feat.SubTitle;
                home.SubDescription = feat.SubDescription;
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                msg = "Lưu thành công";
                return Json(new { Message = msg });
            }
            catch(Exception ex)
            {
                msg = "Lưu không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }          
           
        }

        //public JsonResult Upload(HttpPostedFileBase fileupload)
        //{
        //    string Image = "";
        //    if (fileupload != null)
        //    {
        //        if (fileupload.ContentLength > 0)
        //        {
        //            var filename = Path.GetFileName(fileupload.FileName);
        //            var fname = filename.Replace(" ", "_");
        //            var path = Path.Combine(Server.MapPath("~/Images/imageIntroduce"), fname);
        //            fileupload.SaveAs(path);
        //            Image += fname;
        //        }
        //    }
        //    var home = db.A3Group_Features.Find(1);
        //    if (Image != "")
        //    {
        //        home.Image = Image;
        //    }
        //    db.Entry(home).State = System.Data.Entity.EntityState.Modified;
        //    db.SaveChanges();
        //    return Json(new { status = 201, type = "Success" }, JsonRequestBehavior.AllowGet);
        //}
        [HttpPost]
        public ActionResult Upload(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageIntroduce");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                var home = db.A3Group_Features.Find(1);
                if (name != "")
                {
                    home.Image = name;
                }
                db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Content("chunk uploaded", "text/plain");
        }
    }
}