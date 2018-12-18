using Microsoft.AspNet.Identity.EntityFramework;

namespace JustBlog.Core.Models
{
    public class AppUserRole:IdentityUserRole<int>
    {
        public AppUserRole():base()
        {

        }
    }
}