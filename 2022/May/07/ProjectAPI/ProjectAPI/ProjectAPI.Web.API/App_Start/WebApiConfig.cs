using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjectAPI.Web.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Registration",
                    action = "CheckDuplicates",
                    id = RouteParameter.Optional 
                }
            );
        }
    }
}
