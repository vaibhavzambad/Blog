using System.Data.Entity;
using Ninject.Modules;
using System.Configuration;

namespace JustBlog.Core
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
         {
            string connectionString = ConfigurationManager.ConnectionStrings["BlogContext"].ConnectionString;

            Kernel.Bind<DbContext>().To<BlogContext>().InSingletonScope().WithConstructorArgument
                ("connectionString", connectionString);
        }
    }
}
