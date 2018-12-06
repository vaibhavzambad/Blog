using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBlog.Core.Objects;

namespace JustBlog.Core
{
    public class BlogContext:DbContext
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
