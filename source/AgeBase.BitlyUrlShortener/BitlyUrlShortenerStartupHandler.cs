using System.Web.Routing;
using Umbraco.Core;

namespace AgeBase.BitlyUrlShortener
{
    public class BitlyUrlShortenerStartupHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BitlyUrlShortenerRouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}