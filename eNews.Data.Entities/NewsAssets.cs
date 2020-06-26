using eNews.Data.Entities.Core;
using System.Collections.Generic;

namespace eNews.Data.Entities
{
    public class NewsAssets: BaseEntity
    {
        public List<string> Audios { get; set; }
        public List<string> Videos { get; set; }
        public List<string> Images { get; set; }
    }
}
