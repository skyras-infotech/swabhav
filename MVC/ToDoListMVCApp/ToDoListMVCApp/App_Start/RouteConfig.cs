using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ToDoListMVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                   name: "Default",
                   url: "{controller}/{action}/{id}",
                   defaults: new { controller = "User", action = "Start", id = UrlParameter.Optional }
               );
/*
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "User", action = "LoginUser", id = UrlParameter.Optional }
                );
            }
            else 
            {
                if (HttpContext.Current.User.IsInRole("Admin"))
                {
                    routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
                );
                }
                else 
                {
                    routes.MapRoute(
                        name: "Default",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Tasks", action = "Index", id = UrlParameter.Optional }
                    );
                }
                
            }*/
        }
    }
}
