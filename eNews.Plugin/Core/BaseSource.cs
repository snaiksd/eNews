using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using System.Collections.Generic;

namespace eNews.Plugin.Core
{
    public abstract class BaseSource
    {
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public NewsSourceType SourceType { get; set; }
        public string SourceDescription { get; set; }
        public List<News> News { get; set; }
        public abstract bool Subscribe(List<News> news);
        public abstract List<News> GetNews();
    }
}
