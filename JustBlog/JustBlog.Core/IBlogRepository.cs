using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBlog.Core.Objects;

namespace JustBlog.Core
{
    public interface IBlogRepository<TEntity> : IDisposable where TEntity : class
    {
        IList<Post> GetPosts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
