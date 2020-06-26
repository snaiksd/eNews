using eNews.Common.Models.Enums;
using eNews.Data.Entities.Core;
using System;

namespace eNews.Data.Entities
{
    public class News: BaseEntity
    {
        public Guid NewsId { get; set; }
        public int SourceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public NewsPriority Priority { get; set; }
        public NewsCategory Category { get; set; }
        public NewsReporter Reporter { get; set; }
        public DateTime ReportedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}