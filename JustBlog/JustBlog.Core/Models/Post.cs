﻿using System;
using System.Collections.Generic;

namespace JustBlog.Core.Models
{
    public class Post
    {
        public int ID
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ShortDescription
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Meta
        {
            get;
            set;
        }

        public string UrlSlug
        {
            get;
            set;
        }

        public bool IsPublished
        {
            get;
            set;
        }

        public DateTime PostedOn
        {
            get;
            set;
        }

        public DateTime? ModifiedOn
        {
            get;
            set;
        }

        public virtual Category Category
        {
            get;
            set;
        }

        public virtual ICollection<Tag> Tags
        {
            get;
            set;
        }
    }
}