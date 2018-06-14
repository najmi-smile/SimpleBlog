using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // To get the spacific namespace for the route and avoid any conflict of similar routes present in areas in same namespace
            var nameSpace = new[] { typeof(PostsController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            routes.MapRoute("Login","login", new {controller = "Login", action = "Login" }, nameSpace);
            routes.MapRoute(
                name: "Home", 
                url: "{controller}/{action}",
                defaults: new { controller = "Posts", action = "Index" },
                namespaces: nameSpace
            );
        }
    }
}
