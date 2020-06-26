using eNews.Data.Entities;
using eNews.Data.SqlServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eNews.Services
{
    public class NewsService : INewsService
    {
        private readonly IBaseRepository<News> _newsRepository;

        public NewsService()
        {
            _newsRepository = new NewsRepository();
        }

        // DI - Dependency Injection
        public NewsService(IBaseRepository<News> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public IEnumerable<News> GetNews()
        {
            return _newsRepository.Get();
        }

        public News GetNewsDetail(Guid newsId)
        {
            return _newsRepository.GetByID(newsId);
        }

        public IEnumerable<News> GetNewsByCategory(short CategoryId)
        {
            return _newsRepository.Get().Where(c => c.Category.CategoryId == CategoryId).ToList();
        }

        public void SaveNews()
        {
            // Tempory added Unit Of Work Pattern.
            IUnitOfWork unitOfWork = null; // new NewsRepository();
            try
            {
                _newsRepository.SetUnitWork(unitOfWork);
                _newsRepository.Save();
                unitOfWork.CommitTransaction();
            }
            catch (Exception)
            {
                unitOfWork.RollBackTransaction();
                throw;
            }
        }
    }
}
