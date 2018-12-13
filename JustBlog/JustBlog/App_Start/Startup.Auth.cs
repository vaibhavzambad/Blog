using System;
using JustBlog.Core;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Microsoft.Owin;

namespace JustBlog
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions
        {
            get; private set;
        }

        public static string PublicClientId
        {
            get; private set;
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context , user manager and signin manager to use 
            // a single instance per request
            
        }
    }
}