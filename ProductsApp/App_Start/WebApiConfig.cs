using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ProductsApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
           
            /*  config.Routes.MapHttpRoute(
                  name: "DefaultApi",
                  routeTemplate: "api/{controller}/{year}/{month}/{day}/{hour}/{latidue}",
                  defaults: new
                  {
                      year = RouteParameter.Optional,
                      month = RouteParameter.Optional,
                      day = RouteParameter.Optional,
                      hour = RouteParameter.Optional,
                      latidue = RouteParameter.Optional,

                  }
                   );*/





        }
    }
}
