using eNews.Business.Helpers;
using eNews.Business.Managers;
using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using eNews.Plugin.Core;
using System.Collections.Generic;
using System.Linq;

namespace eNews.Business
{
    public class NewsHost
    {
        public List<News> Publish(BaseSource source)
        {
            List<News> pubNews = new List<News>();
            NewsManager newsManager = new NewsManager();
            BaseSource adSource = SourceFactory.Create("Advert");

            // News = 6 or Hih Prio 8
            int pCount = 8;
            int nCount = 6, aCount = 2;
            int hCount = source.News.Where(h => h.Priority == NewsPriority.High).Count();
            if (hCount > 6 && hCount == 8)
            {
                if (source.News.Count > 6)
                    nCount = 8;
            }
            else if (hCount > 6 && hCount < 8)
            {
                if (source.News.Count > 6)
                    nCount = 7;
            }
            List<News> news = source.News.Take(nCount).ToList();
            foreach (var item in news)
                pubNews.Add(item);

            // Advertisements = 2
            if (nCount != 8)
            {
                adSource.News = newsManager.GetNewsByCategory((short)NewsCategoryType.Advertisements).ToList(); // Added filter to see diff results
                aCount = pCount - nCount;
                List<News> advt = adSource.News.Take(aCount).ToList();
                foreach (var item in advt)
                    pubNews.Add(item);
            }

            bool success = source.Subscribe(pubNews);
            if (success)
            {
                return source.GetNews();
            }
            return null;
        }
    }
}
