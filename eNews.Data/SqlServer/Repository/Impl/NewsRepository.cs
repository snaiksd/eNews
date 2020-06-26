using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace eNews.Data.SqlServer.Repository
{
    public class NewsRepository : IBaseRepository<News>
    {
        List<News> news = new List<News>();

        // TODO : I wanted to implement DI here, mostly UnitOfWork for calling one repository into anoter reposotiry
        public NewsRepository()
        {
            news = GetNews();
        }

        public void Delete(News entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get(IDbCommand dbCommand)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<News> Get()
        {
            return news;
        }

        public News GetByID(Guid id)
        {
            return news.Where(n => n.NewsId == id).FirstOrDefault();
        }

        public IEnumerable GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(News entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetUnitWork(IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }

        public void Update(News entityToUpdate)
        {
            throw new NotImplementedException();
        }


        #region Private 

        private List<News> GetNews()
        {
            NewsCategoryRepository _categoryRepository = new NewsCategoryRepository();
            NewsCategory category1 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Political);
            NewsCategory category2 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Sports);
            NewsCategory category3 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Travel);
            NewsCategory category4 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Entertainment);
            NewsCategory category5 = _categoryRepository.GetNewsCategory((short)NewsCategoryType.Advertisements);

            List<News> news = new List<News>() {
                new News
                {
                     NewsId = Guid.NewGuid(),
                     Category = category1,
                     Title = "Headline 1",
                     Content = "News 1",
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
                     Content = "News 2",
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
                     Content = "News 3",
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
                     Content = "News 4",
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
                     Content = "News 5",
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
                     Content = "News 6",
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
                     Content = "News 7",
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
                     Content = "News 8",
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
                     Content = "News 9",
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
                     Content = "News 10",
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
                     Category = category5,
                     Title = "Headline 1",
                     Content = "Add 1",
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
                     Category = category5,
                     Title = "Headline 2",
                     Content = "Add 2",
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
                     Category = category5,
                     Title = "Headline 3",
                     Content = "Add 3",
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
                     Category = category5,
                     Title = "Headline 4",
                     Content = "Add 4",
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
                     Category = category5,
                     Title = "Headline 5",
                     Content = "Add 5",
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
