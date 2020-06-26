using eNews.Data.Entities;
using eNews.Data.SqlServer.Repository;
using eNews.Services;
using System;
using System.Collections.Generic;

namespace eNews.Business.Managers
{
    public class NewsManager
    {
        private INewsService _newsService;

        // Can Implement DI for INewsService newsService
        public NewsManager()
        {
            _newsService = new NewsService();
        }

        public News GetNewsDetail(Guid newsId)
        {
            return _newsService.GetNewsDetail(newsId);
        }

        public IEnumerable<News> GetNews()
        {
            return _newsService.GetNews();
        }

        public IEnumerable<News> GetNewsByCategory(short CategoryId)
        {
            return _newsService.GetNewsByCategory(CategoryId);
        }

        public void SaveNews()
        {
        }
    }
}
