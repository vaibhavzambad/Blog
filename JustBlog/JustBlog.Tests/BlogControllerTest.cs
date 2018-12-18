using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using JustBlog.Controllers;
using JustBlog.Core;
using JustBlog.Core.Models;
using Moq;

namespace JustBlog.Tests
{
    [TestClass]
    public class BlogControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            Mock<IBlogRepository<Post>> mockRepo = new Mock<IBlogRepository<Post>>();
            BlogController controller = new BlogController(mockRepo.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreatePost()
        {
            // Arrange
            Mock<IBlogRepository<Post>> mockRepo = new Mock<IBlogRepository<Post>>();
            BlogController controller = new BlogController(mockRepo.Object);

            // Act
            ViewResult result = controller.CreatePost() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Posts()
        {
            // Arrange
            Mock<IBlogRepository<Post>> mockRepo = new Mock<IBlogRepository<Post>>();
            BlogController controller = new BlogController(mockRepo.Object);

            //Act
            ViewResult result = controller.Posts();

            //Assert
            Assert.AreEqual("Latest Posts", result.ViewBag.Title);
            Assert.AreEqual("List", result.ViewName);
            Assert.IsNotNull(result.Model);
        }
    }
}
