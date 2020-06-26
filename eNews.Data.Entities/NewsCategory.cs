using eNews.Data.Entities.Core;

namespace eNews.Data.Entities
{
    public class NewsCategory : BaseEntity
    {
        public short CategoryId { get; set; }
        public string CatogryName { get; set; }
    }
}
