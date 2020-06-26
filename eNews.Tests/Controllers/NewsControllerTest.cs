using eNews.Admin.Controllers;
using eNews.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace eNews.Tests.Controllers
{
    [TestClass]
    public class NewsControllerTest
    {
        [TestMethod]
        public void Get_Success()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            IEnumerable<News> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(15, result.Count()); // Total 10 records avail
        }

        [TestMethod]
        public void GetNewsByInternalNewsSource_Success()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            IEnumerable<News> result = controller.Get(0);

            // Assert
            Assert.AreEqual(3, result.Count()); // Total 3 records avail for Internal Source
        }

        [TestMethod]
        public void GetNewsByGoogleNewsSource_Success()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            IEnumerable<News> result = controller.Get(1);

            // Assert
            Assert.AreEqual(3, result.Count()); // Total 3 records avail for PTI news Source
        }

        [TestMethod]
        public void GetNewsByPTINewsSource_Success()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            IEnumerable<News> result = controller.Get(2);

            // Assert
            Assert.AreEqual(8, result.Count()); // Total 8 records avail for PTI Source
        }

        [TestMethod]
        public void GetNews_Page_LessThanOrEqualTo8_Success()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            IEnumerable<News> result = controller.Get(2);

            // Assert
            Assert.AreEqual(true, result.Count() <= 8); // Total 8 records avail for PTI Source
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            NewsController controller = new NewsController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
