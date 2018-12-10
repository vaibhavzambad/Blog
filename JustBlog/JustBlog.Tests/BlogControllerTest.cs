using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using JustBlog.Controllers;
using JustBlog.Core;
using JustBlog.Core.Objects;
using Moq;

namespace JustBlog.Tests
{
    [TestClass]
    public class BlogControllerTest
    {
        [TestMethod]
        public void TestIndexView()
        {
            Mock<IBlogRepository<Post>> mockRepo = new Mock<IBlogRepository<Post>>();
            BlogController controller = new BlogController(mockRepo.Object);
            var result = controller.Posts() as ViewResult;
            Assert.AreEqual("List", result.ViewName);
            var title = controller.Posts().ViewBag.Title;
            Assert.AreEqual("Latest Posts", title);
        }
    }
}
