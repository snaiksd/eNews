using eNews.Data.Entities.Core;
using System;
using System.Collections.Generic;

namespace eNews.Data.Entities
{
    class NewsPaper : BaseEntity
    {
        public short PaperId { get; set; }
        public string PaperName { get; set; }
        public List<Page> Pages { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
