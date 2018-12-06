using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core.Objects
{
    public class Category
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string UrlSlug
        {
            get;
            set;
        }

        public String Description
        {
            get;
            set;
        }

        public virtual ICollection<Post> Posts
        {
            get;
            set;
        }
    }
}