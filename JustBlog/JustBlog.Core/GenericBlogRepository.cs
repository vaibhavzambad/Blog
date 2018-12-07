using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBlog.Core.Objects;

namespace JustBlog.Core
{
    public class GenericBlogRepository<TEntity> : IBlogRepository<TEntity> where TEntity : class
    {
        private BlogContext _context;

        public GenericBlogRepository(BlogContext context)
        {
            this._context = context;
        }

        public IList<Post> GetPosts(int pageNo, int pageSize)
        {
            return _context.Set<Post>().Where(p => p.IsPublished).
                OrderByDescending(p => p.PostedOn).Skip(pageNo * pageSize).
                Take(pageSize).Include(p => p.Category).Include(p => p.Tags)
                .ToList();
        }

        public int TotalPosts()
        {
            return _context.Set<Post>().Where(p => p.IsPublished).Count();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                this.disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GenericBlogRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}