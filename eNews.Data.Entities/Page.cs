using eNews.Data.Entities.Core;
using System.Collections.Generic;

namespace eNews.Data.Entities
{
    public class Page : BaseEntity
    {
        public short PageNo { get; set; }
        public List<News> News { get; set; }
        public List<Advertisement> Advertisements { get; set; }
    }
}
