using System;
using System.Linq;
using System.Web.Http;
using System.Collections.Generic;

namespace FareAlertSystem.WebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}
