using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;
using PagedList;
using PagedList.Mvc;

namespace A3Group.Controllers.WebMaster
{
    public class MemberMasterController : Controller
    {
        a3groupEntities db = new a3groupEntities();
        // GET: MemberMaster
        [Authorize(Roles = "Admin")]
        public ActionResult List(int? page = 1)
        {

            int pageSize = 7;
            int pageNumber = (page ?? 1);
            var lst = db.A3Group_Member.ToList();
            return View(lst.ToPagedList(pageNumber, pageSize));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Create(A3Group_Member mem)
        {
            string msg = "";
            try
            {
                var home = new A3Group_Member();
                home.Name = mem.Name;
                home.Role = mem.Role;
                home.Description = mem.Description;
                if(Session["Image"] != null)
                {
                    home.Image = Session["Image"].ToString();
                }
                db.A3Group_Member.Add(home);
                db.SaveChanges();
                msg = "Tạo thành công";
                return Json(new { Message = msg });
            }
            catch (Exception ex)
            {
                msg = "Lưu không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            Session["MemberID"] = id;
            var rs = db.A3Group_Member.Find(id);
            return View(rs);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Edit(A3Group_Member mem)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Member.Find(mem.ID);
                home.Name = mem.Name;
                home.Role = mem.Role;
                home.Description = mem.Description;
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

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Delete(A3Group_Member mem)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Member.Find(mem.ID);
                db.Entry(home).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                msg = "Xóa thành công";
                return Json(new { Message = msg });
            }
            catch (Exception ex)
            {
                msg = "Xóa không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }
        }

        [HttpPost]
        public ActionResult Upload(int? chunk, string name = "")
        {
            var fileUpload = Request.Files[0];
            var uploadPath = Server.MapPath("~/Images/imageMember");
            chunk = chunk ?? 0;
            using (var fs = new FileStream(Path.Combine(uploadPath, name), chunk == 0 ? FileMode.Create : FileMode.Append))
            {
                var buffer = new byte[fileUpload.InputStream.Length];
                fileUpload.InputStream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                if(Session["MemberID"] != null)
                {
                    string Id = Session["MemberID"].ToString();
                    int id = int.Parse(Id);
                    var home = db.A3Group_Member.Find(id);
                    if (name != "")
                    {
                        home.Image = name;
                    }
                    db.Entry(home).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Session["MemberID"] = null;
                }
                else
                {
                    Session["Image"] = name;
                }            
            }
            return Content("chunk uploaded", "text/plain");
        }
    }
}