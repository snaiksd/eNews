using eNews.Plugin;
using eNews.Plugin.Core;
using eNews.Plugin.Google;
using eNews.Plugin.PTI;
using Unity;

namespace eNews.Business.Helpers
{
    public static class SourceFactory
    {
        private static IUnityContainer unityContainer = null;
        public static BaseSource Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (unityContainer == null)
            {
                unityContainer = new UnityContainer();

                unityContainer.RegisterType<BaseSource, NewsSource>("Internal");
                unityContainer.RegisterType<BaseSource, GoogleNewsSource>("Google");
                unityContainer.RegisterType<BaseSource, PTINewsSource>("PTI");
                unityContainer.RegisterType<BaseSource, AdvertisementSource>("Advert");
            }

            //Design pattern :-  RIP Replace If with Poly
            BaseSource factorybase = unityContainer.Resolve<BaseSource>(Type);
            return factorybase;
        }
    }
}
