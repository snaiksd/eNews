using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using eNews.Plugin.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNews.Plugin.Google
{
    public class GoogleNewsSource  : BaseSource
    {
        public Dictionary<int, List<News>> NewsLists = new Dictionary<int, List<News>>();

        public GoogleNewsSource()
        {
            this.SourceType = NewsSourceType.External;
            this.SourceName = "Google News";
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
