using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DEMO_CW_WEBAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                //routeTemplate: "api/Employee/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
