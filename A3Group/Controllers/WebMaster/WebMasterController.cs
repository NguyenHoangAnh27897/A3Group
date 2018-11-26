using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A3Group.Controllers.WebMaster
{
    public class WebMasterController : Controller
    {
        // GET: WebMaster
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult
    }
}