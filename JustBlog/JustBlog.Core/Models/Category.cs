using System;
using System.Collections.Generic;

namespace JustBlog.Core.Models
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