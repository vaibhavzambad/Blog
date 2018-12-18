using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using JustBlog.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JustBlog.Core
{
    public class BlogContext:IdentityDbContext<AppUser,AppRole,int,IdentityUserLogin<int>,
        AppUserRole,IdentityUserClaim<int>>
    {
        public BlogContext() : base("BlogContext")
        {

        }

        public DbSet<Category> Categories
        {
            get;
            set;
        }

        public DbSet<Tag> Tags
        {
            get;
            set;
        }

        public DbSet<Post> Posts
        {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
