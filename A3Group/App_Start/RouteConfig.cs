using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace A3Group
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Login",
                 url: "tai-khoan/dang-nhap",
                 defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "trang-chu",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "WebMaster",
               url: "trang-quan-li",
               defaults: new { controller = "WebMaster", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
