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
			var difference = db.A3Group_Differences.Where(st => st.id == 1);
			var feature = db.A3Group_Features.Where(st => st.id == 1);
			var service = db.A3Group_Services.Where(st => st.id == 1);
			var price = db.A3Group_Prices.Where(st => st.id == 1);
            var mem = db.A3Group_Member.ToList();
            var pro = db.A3Group_Project.ToList();
            var info = db.A3Group_Information.Find(1);
            var team = db.A3Group_Team.Find(1);
            var quote = db.A3Group_Quotes.Find(1);
            var work = db.A3Group_Works.Find(1);
            var con = db.A3Group_Contact.Find(1);
            var partner = db.A3Group_Partner.ToList();
            var cus = db.A3Group_Customer.ToList();
            var blog = db.A3Group_Blog.ToList();
			home.abo = about;
			home.sli = slider;
			home.diff = difference;
			home.fea = feature;
			home.ser = service;
			home.pri = price;
            home.mem = mem;
            home.pro = pro;
            home.info = info;
            home.team = team;
            home.quotes = quote;
            home.work = work;
            home.con = con;
            home.part = partner;
            home.cus = cus;
            home.blog = blog;
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