using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JustBlog.Core;
using JustBlog.Core.Objects;

namespace JustBlog.Models
{
    public class ListViewModel
    {
        public ListViewModel(IBlogRepository<Post> _postRepository,int p)
        {
            Posts = _postRepository.GetPosts(p - 1, 10);
            TotalPosts = _postRepository.TotalPosts();
        }

        public IList<Post> Posts
        {
            get;
            private set;
        }

        public int TotalPosts
        {
            get;
            private set;
        }
    }
}