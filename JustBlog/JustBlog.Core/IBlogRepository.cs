using System;
using System.Collections.Generic;
using JustBlog.Core.Models;

namespace JustBlog.Core
{
    public interface IBlogRepository<TEntity> : IDisposable where TEntity : class
    {
        IList<Post> GetPosts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
