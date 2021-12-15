using System.Web;
using System.Web.Mvc;

namespace MVC_APPLICATION_CONTROLLERS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
