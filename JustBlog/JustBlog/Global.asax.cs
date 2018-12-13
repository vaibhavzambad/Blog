using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using JustBlog.Core;
using Ninject.Web.Common.WebHost;

namespace JustBlog
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(new RepositoryModule());
            kernel.Bind(typeof(IBlogRepository<>)).
                To(typeof(GenericBlogRepository<>));

            return kernel;
        }

        protected override void OnApplicationStarted()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            base.OnApplicationStarted();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
