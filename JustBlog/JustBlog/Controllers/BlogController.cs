using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBlog.Core;
using JustBlog.Core.Models;
using JustBlog.Models;
using System.Web.UI;

namespace JustBlog.Controllers
{
    [OutputCache(Duration = 20, VaryByParam = "none", Location =
            OutputCacheLocation.Client)]
    public class BlogController : Controller
    {
        private readonly IBlogRepository<Post> _postRepository;

        public BlogController(IBlogRepository<Post> postRepository)
        {
            this._postRepository = postRepository;
        }

        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Posts(int p = 1)
        {
            ListViewModel listViewModel = new ListViewModel(this._postRepository, p);
            ViewBag.Title = "Latest Posts";
            return View("List",listViewModel);
        }

        public ActionResult CreatePost()
        {
            return View();
        }
    }
}