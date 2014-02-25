using System.Web.Mvc;
using System.Web.Routing;

namespace AgeBase.BitlyUrlShortener
{
    public class BitlyUrlShortenerRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "BitlyUrlShortener",
                url: "App_Plugins/AgeBase.BitlyUrlShortener/{action}/{id}",
                defaults: new { controller = "BitlyUrlShortener", action = "Resource", id = UrlParameter.Optional }
                );
        }
    }
}