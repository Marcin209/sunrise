using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ProductsApp
{/*
    /// <summary>
    /// WebApiConfig class
    /// </summary>*/
    public static class WebApiConfig
    {/*
        /// <summary>
        /// Define type of retured object in this case Json object
        /// </summary>*/
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
