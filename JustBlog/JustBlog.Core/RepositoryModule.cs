using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Kernel.Bind(typeof(IBlogRepository<>)).To(typeof(GenericBlogRepository<>));
        }
    }
}
