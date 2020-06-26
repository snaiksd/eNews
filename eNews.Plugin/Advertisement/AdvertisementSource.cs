using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using eNews.Plugin.Core;
using System.Collections.Generic;

namespace eNews.Plugin
{
    public class AdvertisementSource : BaseSource
    {
        public Dictionary<int, List<News>> NewsLists = new Dictionary<int, List<News>>();

        public AdvertisementSource()
        {
            this.SourceType = NewsSourceType.External;
            this.SourceName = "Advertisement";
            this.News = new List<News>();
        }

        public override List<News> GetNews()
        {
            return this.News;
        }

        public override bool Subscribe(List<News> news)
        {
            if (news != null && news.Count > 0)
            {
                if (!NewsLists.ContainsKey(this.SourceId))
                {
                    NewsLists.Add(this.SourceId, news);
                }
                this.News = news;
                return true;
            }
            return false;
        }
    }
}
