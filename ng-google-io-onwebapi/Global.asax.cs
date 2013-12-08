using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Http;

namespace ng_google_io_onwebapi
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                "project", "project/{id}", new { controller = "Project", id = RouteParameter.Optional }
                );
        }

    }
}