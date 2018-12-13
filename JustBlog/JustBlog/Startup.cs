using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustBlog.Startup))]
namespace JustBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // order is very important here
            app.UseCors(CorsOptions.AllowAll);
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            ConfigureAuth(app);

            app.UseWebApi(httpConfiguration);
        }
    }
}