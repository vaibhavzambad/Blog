using Microsoft.AspNet.Identity.EntityFramework;

namespace JustBlog.Core.Models
{
    public class AppRole : IdentityRole<int,AppUserRole>
    {
        public AppRole() : base() { }

        public AppRole(string name, string description) : base()
        {
            this.Name = name;
            this.Description = description;
        }

        public virtual string Description
        {
            get;set;
        }
    }
}