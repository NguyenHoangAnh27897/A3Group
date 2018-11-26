﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;
using PagedList;
using PagedList.Mvc;

namespace A3Group.Controllers.WebMaster
{
    public class ProjectMasterController : Controller
    {
        // GET: ProjectMaster
        a3groupEntities db = new a3groupEntities();
        [Authorize(Roles = "Admin")]
        public ActionResult List(int? page = 1)
        {

            int pageSize = 7;
            int pageNumber = (page ?? 1);
            var lst = db.A3Group_Project.ToList();
            return View(lst.ToPagedList(pageNumber, pageSize));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Create(A3Group_Project mem)
        {
            string msg = "";
            try
            {
                var home = new A3Group_Project();
                home.ProjectName = mem.ProjectName;
                home.Type = mem.Type;
                home.Image = mem.Image;
                db.A3Group_Project.Add(home);
                db.SaveChanges();
                msg = "Tạo thành công";
                return Json(new { Message = msg });
            }
            catch (Exception ex)
            {
                msg = "Tạo không thành công, vui lòng kiểm tra lại";
                return Json(new { Message = msg });
            }
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var rs = db.A3Group_Project.Find(id);
            return View(rs);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Edit(A3Group_Project mem)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Project.Find(mem.ID);
                home.ProjectName = mem.ProjectName;
                home.Type = mem.Type;
                home.Image = mem.Image;
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

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public JsonResult Delete(A3Group_Member mem)
        {
            string msg = "";
            try
            {
                var home = db.A3Group_Project.Find(mem.ID);
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
    }
}