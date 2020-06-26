using eNews.Data.Entities.Core;

namespace eNews.Data.Entities
{
    public class NewsReporter: BaseEntity
    {
        public int ReportedId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Information { get; set; }

        //public NewsAgency Agency { get; set; }
    }
}
