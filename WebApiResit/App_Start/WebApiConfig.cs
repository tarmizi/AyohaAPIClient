using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiResit
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
      //     header('Access-Control-Allow-Headers: Origin, Content-Type, X-Auth-Token'); 
         //   EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "GET,POST", "X-Requested-With, Content-Type, Accept");  
         //config.EnableCors(cors);  

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
