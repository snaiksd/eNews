using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using eNews.Data.SqlServer.Repository;
using eNews.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eNews.Tests.Services
{
    [TestFixture]
    public class NewsServiceTest
    {
        private INewsService _newsService;
        private Mock<IBaseRepository<News>> _mockContext;

        public NewsServiceTest()
        {
            _mockContext = new Mock<IBaseRepository<News>>();
            _newsService = new NewsService(_mockContext.Object);
        }

        [TestCase]
        public void GetMockNews_NotEmpty()
        {
            // Arrange
            IList<News> news = GetNews();
            _mockContext.Setup(m => m.Get()).Returns((news).ToList());

            // Act
            var result = _newsService.GetNews();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(15, result.Count()); // Total 10 records avail
        }

        #region Private 

        private List<News> GetNews()
        {
            NewsCategoryRepository _categoryRepository = new NewsCategoryRepository();
            NewsCategory category1 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Political);
            NewsCategory category2 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Sports);
            NewsCategory category3 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Travel);
            NewsCategory category4 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Entertainment);

            List<News> news = new List<News>() {
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 1",
                     Content = "Content 1",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category2,
                     Title = "Headline 2",
                     Content = "Content 2",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 2,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category3,
                     Title = "Headline 3",
                     Content = "Content 3",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category4,
                     Title = "Headline 4",
                     Content = "Content 4",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 3,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 5",
                     Content = "Content 5",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 6",
                     Content = "Content 6",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 7",
                     Content = "Content 7",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 8",
                     Content = "Content 8",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 4,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 9",
                     Content = "Content 9",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 5,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                },
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category4,
                     Title = "Headline 10",
                     Content = "Content 10",
                     PublishedDate = DateTime.UtcNow,
                     ReportedDate = DateTime.UtcNow,
                     UpdatedDate = null,
                     Reporter = new NewsReporter
                     {
                        ReportedId = 1,
                        FirstName = "fName",
                        LastName = "lName"
                     }
                }
            };
            return news;
        }

        #endregion
    }
}
