using eNews.Data.Entities;
using System;
using System.Collections.Generic;

namespace eNews.Services
{
    public interface INewsService
    {
        News GetNewsDetail(Guid newsId);
        IEnumerable<News> GetNews();
        IEnumerable<News> GetNewsByCategory(short CategoryId);
    }
}
