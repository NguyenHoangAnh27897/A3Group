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
        public ActionResult EditIntroduce(string maintitle, string maindes, string title, string des)
        {
            var home = db.A3Group_Features.Find(1);
            home.MainTitle = maintitle;
            home.MainDescription = maindes;
            home.SubTitle = title;
            home.SubDescription = des;
            db.Entry(home).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("EditIntroduce");
        }

        [HttpPost]
        public JsonResult Upload(HttpPostedFileBase uploader_count)
        {
            string Image = "";
            if (uploader_count != null)
            {
                if (uploader_count.ContentLength > 0)
                {
                    var filename = Path.GetFileName(uploader_count.FileName);
                    var fname = filename.Replace(" ", "_");
                    var path = Path.Combine(Server.MapPath("~/Images/imageIntroduce"), fname);
                    uploader_count.SaveAs(path);
                    Image += fname;
                }
            }
            return Json(new { status = 201, type = "Success" }, JsonRequestBehavior.AllowGet);
        }
    }
}