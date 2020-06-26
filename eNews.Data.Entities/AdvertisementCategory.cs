using eNews.Data.Entities.Core;

namespace eNews.Data.Entities
{
    public class AdvertisementCategory : BaseEntity
    {
        public short CategoryId { get; set; }
        public string CatogryName { get; set; }
    }
}
