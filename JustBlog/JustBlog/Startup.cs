using JustBlog.Core;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustBlog.Startup))]
namespace JustBlog
{
    public partial class Startup
    {
        private IKernel _kernel = null;

        public void Configuration(IAppBuilder app)
        {
            _kernel = CreateKernel();
            app.UseNinjectMiddleware(() => _kernel);
            ConfigureAuth(app);
        }

        private IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind(typeof(IBlogRepository<>)).To(typeof(GenericBlogRepository<>));
            return kernel;
        }
    }
}