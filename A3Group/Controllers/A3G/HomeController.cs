using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A3Group.Models;

namespace A3Group.Controllers
{
    public class HomeController : Controller
    {
		a3groupEntities db = new a3groupEntities();
        public ActionResult Index()
        {
			List<HomeMaster> lst = new List<HomeMaster>();
			HomeMaster home = new HomeMaster();
			var slider = db.A3Group_Sliders.Where(st => st.id == 1);
			var about = db.A3Group_About.Where(st => st.id == 1);
			home.abo = about;
			home.sli = slider;
			lst.Add(home);
            return View(lst);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}