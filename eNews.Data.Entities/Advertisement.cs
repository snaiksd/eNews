using eNews.Data.Entities.Core;
using System;

namespace eNews.Data.Entities
{
    public class Advertisement: BaseEntity
    {
        public Guid AdvertisementId { get; set; }
        public string Headline { get; set; }
        public string Content { get; set; }
        public AdvertisementCategory Category { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
