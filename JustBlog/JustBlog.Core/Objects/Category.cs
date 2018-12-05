using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core.Objects
{
    public class Category
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual String Description
        {
            get;
            set;
        }

        public virtual IList<Post> Posts
        {
            get;
            set;
        }
    }
}
