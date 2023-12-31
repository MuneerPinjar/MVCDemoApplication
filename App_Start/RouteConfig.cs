﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDemoApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Deafult route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Custome Route
            routes.MapRoute(
                name: "Process",
                url: "Process/{action}/{id}",
                defaults: new { controller = "Process", action = "List", id = UrlParameter.Optional }

                );


            routes.MapRoute(
                "Employee", "Employee/{name}", new
                {

                    Controller = "Employee",
                    action = "Search",
                    name = UrlParameter.Optional
                }

                );

            
        }
    }
}
