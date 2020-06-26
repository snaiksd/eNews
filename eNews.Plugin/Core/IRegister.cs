using eNews.Data.Entities;
using System.Collections.Generic;

namespace eNews.Plugin.Core
{
    public interface IRegister
    {
        bool Register(List<News> news);
    }
}
