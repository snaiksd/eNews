using eNews.Business;
using eNews.Business.Helpers;
using eNews.Business.Managers;
using eNews.Business.Validation;
using eNews.Common.Models.Enums;
using eNews.Data.Entities;
using eNews.Plugin;
using eNews.Plugin.Core;
using eNews.Plugin.Google;
using eNews.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace eNews.Admin.Controllers
{
    public class NewsController : ApiController
    {
        NewsManager newsManager;

        //can create a seperate interface and loosely couple the business layer
        public NewsController()
        {
            newsManager = new NewsManager();
        }
        // GET: api/News
        public IEnumerable<News> Get()
        {
            return newsManager.GetNews();
        }

        // GET: api/News/5
        public List<News> Get(int id)
        {
            BaseSource newsSource;
            NewsHost newsPublisher = new NewsHost();

            // This code can be changed lateron to Factory patten inside Business
            if (id == 0)
            {
                newsSource = SourceFactory.Create("Internal");
                newsSource.SourceId = 0;
                newsSource.News = newsManager.GetNewsByCategory((short)NewsCategoryType.Travel).ToList(); // Added filter to see diff results
                return newsPublisher.Publish(newsSource);
            }
            else if (id == 1)
            {
                newsSource = SourceFactory.Create("Google");
                newsSource.SourceId = 1;
                newsSource.News = newsManager.GetNewsByCategory((short)NewsCategoryType.Sports).ToList(); // Added filter to see diff results
                return newsPublisher.Publish(newsSource);
            }
            else if (id == 2)
            {
                newsSource = SourceFactory.Create("PTI");
                newsSource.SourceId = 2;
                newsSource.News = newsManager.GetNewsByCategory((short)NewsCategoryType.Political).ToList(); // Added filter to see diff results                
                return newsPublisher.Publish(newsSource);
            }
            return null;
        }

        // POST: api/News
        public void Post([FromBody]string value)
        {
            ValidationRule validationRule = new ValidationRule();
            if (validationRule.Validate())
            {
                // Process
            }
        }

        // PUT: api/News/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/News/5
        public void Delete(int id)
        {
        }
    }
}
