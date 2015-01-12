using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DealerWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ImageDownload",
                url: "Image/{size}/{id}/{name}",
                defaults: new { controller = "Image", action = "Download", id=@"\d" }
            );

            routes.MapRoute(
                name: "ImageUpload",
                url: "Image/{type}/{name}",
                defaults: new { controller = "Image", action = "Upload" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            /* Example Urls
             * /Inventory
             * /Inventory/Category/8-Dump-Trailers
             * /Inventory/Category/8-Dump-Trailers/28-Load-Trail-10-23-hydraulic-lift-dump
             * /Image/thumbnail/387-Load-Trail-10-23-hydraulic-lift-dump.jpg
             * 
             * 
             * 
            */
        }
    }
}