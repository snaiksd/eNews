using eNews.Common.Models.Enums;
using eNews.Data.Entities.Core;
using System;
using System.Collections.Generic;

namespace eNews.Data.Entities
{
    public class Source : BaseEntity
    {
        public int SourceId { get; set; }
        public string URL { get; set; }

    }
}